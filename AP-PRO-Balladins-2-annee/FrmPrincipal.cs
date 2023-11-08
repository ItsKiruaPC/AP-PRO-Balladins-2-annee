using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AP_PRO_Balladins_2_annee.Classe_passerelle;

namespace AP_PRO_Balladins_2_annee
{
    public partial class FrmPrincipal : Form
    {
        //parametre pour déplacer la fenetre -->
        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //<--jusqu'içi
        public string nom_header;
        private Form _currentChildForm;

        public FrmPrincipal()
        {
            InitializeComponent();
        }
        
        private void OpenChildForm(Form childForm)
        {
            _currentChildForm?.Close();
            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Form.Controls.Add(childForm);
            panel_Form.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //Cache au démarrage les boutons d'accées au formulaire sur le coté tant que l'utilisateur n'est pas connecté
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            btn_Chambre.Visible = false;
            btn_Hotel.Visible = false;
            btn_Reserv.Visible = false;
            btn_deconnect.Visible = false;
            OpenChildForm(new FrmConnexion());
        }

        //Affiche les informations de l'application (Boutton de navigation, titre de l'application) lorsque l'utilisateur est connecté
        public void Switch_Visibility(bool isVisible)
        {
            lbl_Nom.Text = nom_header;
            btn_Chambre.Visible = isVisible;
            btn_Hotel.Visible = isVisible;
            btn_Reserv.Visible = isVisible;
            btn_deconnect.Visible = isVisible;
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = @"Bienvenue sur l'application";
            notifyIcon1.BalloonTipTitle = @"Balladin";
            notifyIcon1.ShowBalloonTip(100);
        }

        //Ouvre le formulaire de gestion des hotels
        private void btn_Hotel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TogleButton());
        }

        //Ouvre le formulaire de gestion des chambres de l'hotel
        private void btn_Chambre_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGererChambre());
        }
        //Ouvre le formulaire des reservations
        private void btn_Reserv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmReservation());
        }
        //Ferme l'application lorsque l'utilisateur clique à l'exterieur de l'appli
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }
        //Bouton qui permet de fermer l'application 
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Varglobale.Frm2.ShowDialog();
        }

        //Permet de mettre l'application en pleine écran
        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        //Bouton qui permet de minimisé l'application dans la barre Windows
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Boutton qui permet de déconnecter l'utilisateur de l'application
        private void btn_deconnect_Click(object sender, EventArgs e)
        {
            HotelDao.DeconnexionHotel();
            FrmPrincipal_Load(sender, e);
        }
    }
}
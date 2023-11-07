using System;
using System.Windows.Forms;
using System.Drawing;
using AP_PRO_Balladins_2_annee.Classe_passerelle;

namespace AP_PRO_Balladins_2_annee
{
    public partial class FrmPrincipal : Form
    {
        //parametre pour déplacer la fenetre -->
        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
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
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            btn_Chambre.Enabled = false;
            btn_Hotel.Enabled = false;
            btn_Reserv.Enabled = false;
            btn_deconnect.Visible = false;
            OpenChildForm(new FrmConnexion());
        }

        public void Switch_Visibility(bool isVisible)
        {
            lbl_Nom.Text = nom_header;
            btn_Chambre.Enabled = isVisible;
            btn_Hotel.Enabled = isVisible;
            btn_Reserv.Enabled = isVisible;
            btn_deconnect.Visible = isVisible;
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = @"Bienvenue sur l'application";
            notifyIcon1.BalloonTipTitle = @"Balladin";
            notifyIcon1.ShowBalloonTip(100);
        }
        private void btn_Hotel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TogleButton());
        }

        private void btn_Chambre_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGererChambre());
        }
        private void btn_Reserv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmReservation());
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Varglobale.Frm2.ShowDialog();
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_deconnect_Click(object sender, EventArgs e)
        {
            HotelDao.DeconnexionHotel();
            FrmPrincipal_Load(sender,e);
        }
        
    }
}
using System;
using System.Windows.Forms;

namespace AP_PRO_Balladins_2_annee
{
    public partial class FrmPrincipal : Form
    {
        //parametre pour déplacer la fenetre -->
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //<--jusqu'içi
        
        private Form _currentChildForm;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (_currentChildForm != null)
            {
                _currentChildForm.Close();
            }
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
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;

            notifyIcon1.BalloonTipText = @"Bienvenue sur l'application";

            notifyIcon1.BalloonTipTitle = @"Balladin";

            notifyIcon1.ShowBalloonTip(100);
            
            //lbl_Nom.Text = varglobale.lehotel.nom;
            OpenChildForm(new FrmConnexion());
        }
        private void FrmAccueil_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAccueil());
        }
        private void chambreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGererHotel frm1 = new FrmGererHotel();
            frm1.ShowDialog();
        }

        private void btn_Hotel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGererHotel());
        }

        private void btn_Chambre_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGererChambre());
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            varglobale.frm2.ShowDialog();
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
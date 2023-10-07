using System;
using System.Windows.Forms;

namespace AP_PRO_Balladins_2_annee
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lbl_Nom.Text = varglobale.lehotel.nom;
        }

        private void chambreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGererHotel frm1 = new FrmGererHotel();
            frm1.ShowDialog();
        }
    }
}
using System;
using System.Linq;
using System.Windows.Forms;

namespace AP_PRO_Balladins_2_annee
{
    public partial class FrmGererHotel : Form
    {
        public FrmGererHotel()
        {
            InitializeComponent();
        }
        private void FrmGererHotel_Load(object sender, EventArgs e)
        {
            RefreshHotel();
        }

        public void RefreshHotel()
        {
            txtMdp.PasswordChar = '*';
            txtNom.Text = varglobale.lehotel.nom;
            txtAdresse.Text = varglobale.lehotel.adr1;
            txtDescription.Text = varglobale.lehotel.deslong;
            txtCourt.Text = varglobale.lehotel.descourt;
            txtTel.Text = varglobale.lehotel.tel;
            txtMdp.Text = varglobale.lehotel.password;
            txtPrix.Text = varglobale.lehotel.prix.ToString();
            //txtCourt.Text = varglobale.lehotel.equipement.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes vous sur de vouloir modifier l'hotel ?", "Confirmation", MessageBoxButtons.OKCancel);
            
            if (result == DialogResult.OK)
            {
                var hotel = varglobale.lehotel;

                if (hotel != null)
                {
                    hotel.tel = txtTel.Text;
                    hotel.nom = txtNom.Text;
                    hotel.adr1 = txtAdresse.Text;
                    hotel.descourt = txtDescription.Text;
                    hotel.password = txtMdp.Text;
                    hotel.prix = Convert.ToDouble(txtPrix.Text);
                    
                    using (var db = new ConnexionDb())
                    {
                        db.SaveChanges();
                    }
                }
                RefreshHotel();
            }
            else
            {
                RefreshHotel();
            }
        }
        private void btnVoirMdp_Click(object sender, EventArgs e)
        {
            if (txtMdp.PasswordChar == '*')
            {
                txtMdp.PasswordChar = '\0';
            }
            else 
            {
                txtMdp.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDescription.Multiline = true; 
            txtDescription.ScrollBars = ScrollBars.Vertical; // Activer la barre de défilement verticale si nécessaire
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            txtDescription.Multiline = true;
            txtDescription.ScrollBars = ScrollBars.Vertical; // Activer la barre de défilement verticale si nécessaire
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

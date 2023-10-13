using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            txtTel.Text = varglobale.lehotel.tel;
            txtMdp.Text = varglobale.lehotel.password;
            txtPrix.Text = varglobale.lehotel.prix.ToString();
            txtEquipement.Text = varglobale.lehotel.equipement.ToString();
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
                using (var db = new ConnexionDb())
                {
                    var hotel = db.hotel.Where(h => h.nohotel == varglobale.lehotel.nohotel).SingleOrDefault();

                    if (hotel != null)
                    {
                        hotel.tel = txtTel.Text;
                        hotel.nom = txtNom.Text;
                        hotel.adr1 = txtAdresse.Text;
                        hotel.descourt = txtDescription.Text;
                        hotel.password = txtMdp.Text;
                        db.SaveChanges();
                    }
                }
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
    }
}

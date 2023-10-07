using System;
using System.Linq;
using System.Windows.Forms;

namespace AP_PRO_Balladins_2_annee
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_identifiant.Text = @"LYON - DARDILLY";
            txt_password.Text = @"testtest";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_identifiant.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                lblinfos.Text = @"Veuillez saisir votre mot de passe et votre utilisateur";
            }
            else
            {
                try
                {
                    
                    if (varglobale.connexionDb.hotel.Any(hotel => hotel.nom == txt_identifiant.Text && hotel.password == txt_password.Text))
                    {
                        varglobale.lehotel = varglobale.connexionDb.hotel.FirstOrDefault(hotel => hotel.nom == txt_identifiant.Text && hotel.password == txt_password.Text);
                        MessageBox.Show(@"Bienvenue: " + txt_identifiant.Text);
                        var formulaireOuvert = new FrmGererHotel();
                        formulaireOuvert.Show();

                    }
                    else
                    {
                        MessageBox.Show(@"Mauvais identifiant veuillez réessayer");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            {
                if (varglobale.connexionDb.hotel.Any(hotel => hotel.nom == txt_identifiant.Text && hotel.password == null))
                {
                    using (var db = new ConnexionDb())
                    {
                        var result = db.hotel.SingleOrDefault(hotel => hotel.nom == txt_identifiant.Text);
                        if (result != null && txt_password.Text != "" && txt_password.Text.Length >= 8)
                        {
                            result.password = txt_password.Text;
                            db.SaveChanges();
                        }
                        else
                        {
                            lblinfos.Text = @"Veuillez ecrire le bon mot de passe";
                        }
                    }

                }
                else
                {
                    MessageBox.Show(@"L'identifiant ou le mdp est faux");
                }

            }
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                
                e.Handled = true;
            }
        }
    }

}

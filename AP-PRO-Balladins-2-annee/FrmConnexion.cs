using System;
using System.Linq;
using System.Windows.Forms;
using AP_PRO_Balladins_2_annee.Classe_passerelle;

namespace AP_PRO_Balladins_2_annee
{
    public partial class FrmConnexion : Form
    {
        FrmPrincipal _mainForm = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();

        public FrmConnexion()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_identifiant.Text = @"LYON - DARDILLY";
            txt_password.Text = @"test";
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
                    if (Varglobale.ConnexionDb.hotel.Any(hotel => hotel.nom == txt_identifiant.Text && hotel.password == txt_password.Text))
                    {
                        Varglobale.Lehotel = Varglobale.ConnexionDb.hotel.FirstOrDefault(hotel => hotel.nom == txt_identifiant.Text && hotel.password == txt_password.Text);
                        MessageBox.Show(@"Bienvenue: " + txt_identifiant.Text);
                        this.Hide();
                        _mainForm.Switch_Visibility(true);
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
                if (Varglobale.ConnexionDb.hotel.Any(hotel => hotel.nom == txt_identifiant.Text && hotel.password == null))
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
    }
}

using AP_PRO_Balladins_2_annee.Classe_Metier;
using AP_PRO_Balladins_2_annee.Classe_passerelle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            txt_identifiant.Text = "LYON - DARDILLY";
            txt_password.Text = "test";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_identifiant.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                lblinfos.Text = "Veuillez saisir votre mot de passe et votre utilisateur";
            }
            else
            {
                try
                {
                    
                    if (varglobale.connexionDb.hotel.Where(hotel => hotel.nom == txt_identifiant.Text && hotel.password == txt_password.Text).Any())
                    {
                        varglobale.lehotel = varglobale.connexionDb.hotel.Where(hotel => hotel.nom == txt_identifiant.Text && hotel.password == txt_password.Text).FirstOrDefault();
                        MessageBox.Show("Bienvenue: " + txt_identifiant.Text);
                        FrmGererHotel formulaireOuvert = new FrmGererHotel();
                        formulaireOuvert.Show();

                    }
                    else
                    {
                        MessageBox.Show("Mauvais identifiant veuillez réessayer");
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            {
                if (varglobale.connexionDb.hotel.Where(hotel => hotel.nom == txt_identifiant.Text && hotel.password == null).Any())
                {
                    using (var db = new ConnexionDb())
                    {
                        var resultat = db.hotel.Where(hotel => hotel.nom == txt_identifiant.Text).SingleOrDefault();
                        if (resultat != null)
                        {
                            resultat.password = txt_password.Text;
                            db.SaveChanges();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("L'identifiant ou le mdp est faux");
                }

            }
        }
    }

}

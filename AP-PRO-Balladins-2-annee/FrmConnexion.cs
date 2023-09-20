using AP_PRO_Balladins_2_annee.Classe_Metier;
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
            label1.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (varglobale.connexionDb.hotel.Where(hotel => hotel.nom == txt_identifiant.Text && hotel.password == txt_password.Text).Any())
                {

                    MessageBox.Show("Valide");
                }
                else
                {
                    MessageBox.Show("Non valide");
                }
            }
            catch (Exception)
            {
               
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (varglobale.connexionDb.hotel.Where(hotel => hotel.nom == txt_identifiant.Text && hotel.password == null).Any())
            {
                varglobale.lehotel.password = txt_password.Text;
                varglobale.connexionDb.SaveChanges();
                MessageBox.Show("Vu que l'identifiant est juste mais que le mot de passe n'en a pas alors j'ai jouter celui ci");
            }
            else
            {
                MessageBox.Show("L'identifiant ou le mdp est faux");
            }
            
        }
    }

}

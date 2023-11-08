using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using AP_PRO_Balladins_2_annee.Classe_passerelle;
using AP_PRO_Balladins_2_annee.Properties;

namespace AP_PRO_Balladins_2_annee
{
    public partial class TogleButton : Form
    {
        public TogleButton()
        {
            InitializeComponent();
        }

        private void FrmGererHotel_Load(object sender, EventArgs e)
        {
            RefreshHotel();
        }

        //Rafraichit les informations de l'hotel lors des modifications de celui-ci
        private void RefreshHotel()
        {
            chkBox1.Image = Resources.hide_regular_24;
            txtMdp.PasswordChar = '*';
            txtNom.Text = Varglobale.Lehotel.nom;
            txtAdr1.Text = Varglobale.Lehotel.adr1;
            txtAdr2.Text = Varglobale.Lehotel.adr2;
            txtLong.Text = Varglobale.Lehotel.deslong;
            txtCourt.Text = Varglobale.Lehotel.descourt;
            txtTel.Text = Varglobale.Lehotel.tel;
            txtMdp.Text = Varglobale.Lehotel.password;
            txtPrix.Text = Varglobale.Lehotel.prix.ToString();
            chklist.Items.Clear();

            //Affiche les équipements dans des boutons radios
            foreach (var emp in Varglobale.ConnexionDb.equipement)
            {
                chklist.Items.Add(emp.lib);
                chklist.SetItemChecked(chklist.Items.Count - 1, Varglobale.Lehotel.equipement.Contains(emp));
            }
        }

        //Permet d'afficher les informations de l'hotel (Telephone,Nom,Adresse,Description,MDP,Equipement)
        private void AjoutElements()
        {
            var hotel = Varglobale.Lehotel;

            hotel.tel = txtTel.Text;
            hotel.nom = txtNom.Text;
            hotel.adr1 = txtAdr1.Text;
            hotel.adr2 = txtAdr2.Text;
            hotel.deslong = txtLong.Text;
            hotel.descourt = txtCourt.Text;
            hotel.password = txtMdp.Text;
            hotel.prix = Convert.ToDouble(txtPrix.Text);
            hotel.equipement.Clear();

            //Affiche dans des boutons radio les équipements de l'hotel, possibilité d'ajouter ou supprimer des équipements 
            foreach (var emp in chklist.CheckedItems)
            {
                var unEquipement = Varglobale.ConnexionDb.equipement.FirstOrDefault(e => e.lib == emp.ToString());
                hotel.equipement.Add(unEquipement);
            }

            //Sauvegarde les nouvelles informations dans la base de donnée
            try
            {
                Varglobale.ConnexionDb.SaveChanges();
                MessageBox.Show($@"{hotel.equipement.Count} équipements ajoutés à l'hôtel.");
            }
            catch (DbEntityValidationException ex)
            {
                //Fonctions de débogage pour parcourir les erreurs
                foreach (var validationErrors in ex.EntityValidationErrors)
                foreach (var validationError in validationErrors.ValidationErrors)
                    MessageBox.Show($@"Erreur de validation : {validationError.ErrorMessage}");
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException != null)
                {
                    var innerException = ex.InnerException;
                    while (innerException.InnerException != null) innerException = innerException.InnerException;

                    MessageBox.Show(
                        $@"Erreur lors de la mise à jour de la base de données : {innerException.Message}");
                }
                else
                {
                    MessageBox.Show(@"Erreur inconnue lors de la mise à jour de la base de données.");
                }
            }
        }

        //Permet la modification des informations de l'hotel
        private void btnEditer_Click(object sender, EventArgs e)
        {
            //Demande à l'utilisateur la confirmation de la modification
            var result = MessageBox.Show(@"Êtes vous sur de vouloir modifier l'hotel ?", @"Confirmation",
                MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
                //Appelle la méthode AjoutElement si la modification est voulu
                AjoutElements();
            else
                //Appelle la méthode RefreshHotel en cas d'erreur de l'utilisateur lors de la modificatiion
                RefreshHotel();
        }

        //Affiche ou cache le mot de passe de l'hotel (element de sécurité)
        private void btnVoirMdp_Click(object sender, EventArgs e)
        {
            txtMdp.PasswordChar = txtMdp.PasswordChar == '*' ? '\0' : '*';
        }

        //Interdit la saisie de caractére différent d'un chiffre ou d'un numéro
        private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
        //Permet de modifier l'image du bouton "Voir MDP" en fonction de l'etat de ce dernier
        private void chkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkBox1.Checked)
            {
                chkBox1.Image = Resources.show_regular_24;
                btnVoirMdp_Click(sender, e);
            }
            else
            {
                chkBox1.Image = Resources.hide_regular_24;
                btnVoirMdp_Click(sender, e);
            }
        }
    }
}
using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using AP_PRO_Balladins_2_annee.Classe_passerelle;

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

        private void RefreshHotel()
        {
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
            foreach (var emp in Varglobale.ConnexionDb.equipement)
            {
                chklist.Items.Add(emp.lib);
                chklist.SetItemChecked(chklist.Items.Count - 1, Varglobale.Lehotel.equipement.Contains(emp));
            }
        }

        private void AjoutEquipements()
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

            foreach (var emp in chklist.CheckedItems)
            {
                var unEquipement = Varglobale.ConnexionDb.equipement.FirstOrDefault(e => e.lib == emp.ToString());
                hotel.equipement.Add(unEquipement);

            }

            try
            {
                Varglobale.ConnexionDb.SaveChanges();
                MessageBox.Show($@"{hotel.equipement.Count} équipements ajoutés à l'hôtel.");
            }
            catch (DbEntityValidationException ex)
            {

                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show($@"Erreur de validation : {validationError.ErrorMessage}");
                    }
                }
            }
            catch (DbUpdateException ex)
            {

                if (ex.InnerException != null)
                {
                    Exception innerException = ex.InnerException;
                    while (innerException.InnerException != null)
                    {
                        innerException = innerException.InnerException;
                    }

                    MessageBox.Show(
                        $"Erreur lors de la mise à jour de la base de données : {innerException.Message}");
                }
                else
                {
                    MessageBox.Show("Erreur inconnue lors de la mise à jour de la base de données.");
                }
            }
        }

private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(@"Êtes vous sur de vouloir modifier l'hotel ?", @"Confirmation", MessageBoxButtons.OKCancel);
            
            if (result == DialogResult.OK)
            {
                AjoutEquipements();
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
        private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;
using static AP_PRO_Balladins_2_annee.varglobale;

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
            dataGridView1.ColumnCount=2;
            dataGridView1.Columns[0].HeaderText = "Selection";
            dataGridView1.Columns[1].HeaderText = "Equipements";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            txtMdp.PasswordChar = '*';
            txtNom.Text = lehotel.nom;
            txtAdresse.Text = lehotel.adr1;
            txtDescription.Text = lehotel.deslong;
            txtCourt.Text = lehotel.descourt;
            txtTel.Text = lehotel.tel;
            txtMdp.Text = lehotel.password;
            txtPrix.Text = lehotel.prix.ToString();
            foreach (var emp in connexionDb.equipement.Select(h => h.lib))
            {
                dataGridView1.Rows.Add("", emp);h
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
            DialogResult result = MessageBox.Show("Êtes vous sur de vouloir modifier l'hotel ?", "Confirmation", MessageBoxButtons.OKCancel);
            
            if (result == DialogResult.OK)
            {
                var hotel = lehotel;

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

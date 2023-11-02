using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using AP_PRO_Balladins_2_annee.Classe_passerelle;
using static AP_PRO_Balladins_2_annee.Classe_passerelle.Varglobale;

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
            DataGridViewCheckBoxColumn test = new DataGridViewCheckBoxColumn();
            test.HeaderText = @"Selection";
            dataGridView1.Columns.Add(test);
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[1].HeaderText = @"Equipements";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].ReadOnly = false;
            dataGridView1.Columns[1].ReadOnly = true;
            txtMdp.PasswordChar = '*';
            txtNom.Text = Lehotel.nom;
            txtAdr1.Text = Lehotel.adr1;
            txtAdr2.Text = Lehotel.adr2;
            txtLong.Text = Lehotel.deslong;
            txtCourt.Text = Lehotel.descourt;
            txtTel.Text = Lehotel.tel;
            txtMdp.Text = Lehotel.password;
            txtPrix.Text = Lehotel.prix.ToString();
            dataGridView1.Rows.Clear();
            foreach (var emp in Varglobale.ConnexionDb.equipement)
            {
                dataGridView1.Rows.Add(Lehotel.equipement.Contains(emp), emp.lib);
            }
        }
        //Attention en préparation...
        /*private void AjoutEquipements()
        {
            using (var db = new ConnexionDb())
            {
                var hotel = db.hotel.Include(hotel1 => hotel1.equipement).FirstOrDefault(h => h.nohotel == Lehotel.nohotel);

                if (hotel != null)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0] is DataGridViewCheckBoxCell checkBoxCell && Convert.ToBoolean(checkBoxCell.Value))
                        {
                            string libelleEquipement = row.Cells[1].Value.ToString();
                            int noEquipement = Convert.ToInt32(row.Cells[0].Value);
                            var equipement = Varglobale.ConnexionDb.equipement.FirstOrDefault(e => e.lib == libelleEquipement && e.noequ == noEquipement);
                            if (equipement != null)
                            {
                                hotel.equipement.Add(equipement);
                            }
                        }
                    }
                    db.SaveChanges();

                    MessageBox.Show($@"{hotel.equipement.Count} équipements ajoutés à l'hôtel.");
                }
                else
                {
                    MessageBox.Show(@"Assurez-vous d'avoir un hôtel.");
                }
            }*/
        // var hotel = Lehotel;
        // using (var db = new ConnexionDb())
        // {
        //     if (hotel != null)
        //     {
        //         List<equipement> equipementsAajouter = new List<equipement>();
        //
        //         foreach (DataGridViewRow emp in dataGridView1.Rows)
        //         {
        //             if (emp.Cells[0].Value is bool isChecked && isChecked)
        //             {
        //                 int noequ = Convert.ToInt32(emp.Cells[0].Value);
        //                 var equipement = db.equipement.FirstOrDefault(e => e.noequ == noequ);
        //
        //                 if (equipement != null)
        //                 {
        //                     equipementsAajouter.Add(equipement);
        //                 }
        //             }
        //         }
        //         foreach (var emp in equipementsAajouter)
        //         {
        //             hotel.equipement.Add(emp);
        //         }
        //         db.SaveChanges();
        //     }
        // }

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
                var hotel = Lehotel;

                if (hotel != null)
                {
                    hotel.tel = txtTel.Text;
                    hotel.nom = txtNom.Text;
                    hotel.adr1 = txtAdr1.Text;
                    hotel.adr2 = txtAdr2.Text;
                    hotel.deslong = txtLong.Text;
                    hotel.descourt = txtCourt.Text;
                    hotel.password = txtMdp.Text;
                    hotel.prix = Convert.ToDouble(txtPrix.Text);
                    
                    using (var db = new ConnexionDb())
                    {
                        db.SaveChanges();
                    }
                }
                //AjoutEquipements();
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
        private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

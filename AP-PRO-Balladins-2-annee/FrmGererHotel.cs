using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            txtMdp.PasswordChar = '*';
            txtNom.Text = varglobale.lehotel.nom;
            txtAdresse.Text = varglobale.lehotel.adr1;
            txtDescription.Text = varglobale.lehotel.deslong;
            txtTel.Text = varglobale.lehotel.tel;
            txtMdp.Text = varglobale.lehotel.password;
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            using (var db = new ConnexionDb())
            {
                var hotel = db.hotel.Where(h => h.nom == varglobale.lehotel.nom).SingleOrDefault();
                
                if (hotel != null)
                {
                    hotel.tel = txtTel.Text;
                    db.SaveChanges();
                }
            }
            //using (var db = new ConnexionDb())
            //{
            //    var hotel = db.hotel.FirstOrDefault(h => h.nom == txtNom.Text);
            //    if (hotel != null)
            //    {
            //        if (txtTel.Text != null && txtTel.Text != hotel.tel)
            //        {
            //            hotel.tel = txtTel.Text;
            //            db.SaveChanges();
            //        }
            //    }
            //}


        }






















































































































































































































































































































































        private void chambreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FrmGererChambre frm2 = new FrmGererChambre();
            frm2.ShowDialog();
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

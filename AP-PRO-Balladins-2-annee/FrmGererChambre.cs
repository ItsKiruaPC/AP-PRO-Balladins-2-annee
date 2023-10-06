using AP_PRO_Balladins_2_annee.Classe_passerelle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace AP_PRO_Balladins_2_annee
{
    public partial class FrmGererChambre : Form
    {
        public FrmGererChambre()
        {
            InitializeComponent();
        }
        HotelDAO hotelHelper = new HotelDAO();
        ChambreDAO chambreHelp = new ChambreDAO();
        chambre unT = new chambre();
        

        private void FrmGererChambre_Load(object sender, EventArgs e)
        {
            grd_view.RowHeadersVisible = false;
            grd_view.AllowUserToResizeColumns = false;
            grd_view.AllowUserToResizeRows = false;
            grd_view.AllowUserToAddRows = false;
            grd_view.ColumnCount = 2;
            grd_view.EditMode = DataGridViewEditMode.EditProgrammatically;
            grd_view.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd_view.Columns[0].HeaderText = "Numéro";
            grd_view.Columns[1].HeaderText = "Nom";
            txt_Nom.Text = varglobale.lehotel.nom;
            grd_view.Rows.Clear();

            List<chambre> chambreNames = chambreHelp.ChargerChambre();
            List<int> listChambre = chambreHelp.ListChambre();

            cbo_chambre.DataSource = listChambre;

            if (varglobale.lehotel.nom != null)
            foreach(var emp in chambreNames)
            grd_view.Rows.Add(emp.nochambre, emp.hotel.nom);

        }

        private void chambreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGererHotel frm1 = new FrmGererHotel();
            frm1.ShowDialog();
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                chambre unC = new chambre();
                unC.nohotel = varglobale.lehotel.nohotel;
                unC.nochambre = Convert.ToInt32(cbo_chambre.SelectedItem);
                List<int> listChambre = chambreHelp.ListChambre();
                chambre lol= new chambre();
                foreach (var emp in chambreHelp.ChargerChambre())
                {
                    if (emp.nochambre == unC.nochambre)
                    {
                        lol = emp;
                    }
                }
                if (unC.nochambre != lol.nochambre || lol.nochambre == 0)
                {
                    varglobale.lehotel.chambre.Add(unC);
                    varglobale.connexionDb.SaveChanges();
                    FrmGererChambre_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Ca existe déjà");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            chambre unC = new chambre();
            unC.nohotel = varglobale.lehotel.nohotel;
            int nochambre = Convert.ToInt32(cbo_chambre.SelectedItem);
            chambre chambreasupr = varglobale.lehotel.chambre.Where(chambre => chambre.nochambre == nochambre).FirstOrDefault();
            varglobale.lehotel.chambre.Remove(chambreasupr);
            varglobale.connexionDb.SaveChanges();

            FrmGererChambre_Load(sender, e);

        }
    }
}

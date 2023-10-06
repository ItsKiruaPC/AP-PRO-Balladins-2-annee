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
        chambre unC = new chambre();
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

            List<chambre> chambreNames = chambreHelp.ChargerChambre();
            List<int> listChambre = chambreHelp.ListChambre();

            cbo_chambre.DataSource = listChambre;

            if (varglobale.lehotel.nom != null)
            foreach(var emp in chambreNames)
            grd_view.Rows.Add(emp.nochambre, varglobale.lehotel.nom);

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
        //Servira a actualiser automatiquement les données
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lst_view_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
           
            unC.nohotel = varglobale.lehotel.nohotel;
            unC.nochambre=Convert.ToInt32(cbo_chambre.SelectedItem);

            varglobale.lehotel.chambre.Add(unC);
            varglobale.connexionDb.SaveChanges();

            
            grd_view.DataSource = unC.hotel.chambre;

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            unC.nohotel = varglobale.lehotel.nohotel;
            unC.nochambre = Convert.ToInt32(cbo_chambre.SelectedItem);

            varglobale.lehotel.chambre.Remove(unC);
            varglobale.connexionDb.SaveChanges();

            
            grd_view.DataSource = unC.hotel.chambre;
        }
    }
}

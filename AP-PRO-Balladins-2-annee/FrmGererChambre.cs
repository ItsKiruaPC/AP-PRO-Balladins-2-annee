using AP_PRO_Balladins_2_annee.Classe_passerelle;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AP_PRO_Balladins_2_annee
{
    public partial class FrmGererChambre : Form
    {
        public FrmGererChambre()
        {
            InitializeComponent();
        }

        private readonly ChambreDAO _chambreHelp = new ChambreDAO();

        private void FrmGererChambre_Load(object sender, EventArgs e)
        {
            grd_view.ColumnCount = 2;
            
            grd_view.Columns[0].HeaderText = @"Numéro";
            grd_view.Columns[1].HeaderText = @"Nom";
            
            grd_view.RowHeadersVisible = false;
            grd_view.AllowUserToAddRows = false;
            grd_view.AllowUserToResizeRows = false;
            grd_view.AllowUserToResizeColumns = false;
            
            grd_view.EditMode = DataGridViewEditMode.EditProgrammatically;
            grd_view.BackgroundColor = System.Drawing.SystemColors.Control;
            grd_view.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grd_view.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grd_view.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grd_view.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            txt_Nom.Text = varglobale.lehotel.nom;
            grd_view.Rows.Clear();

            var chambreNames = _chambreHelp.ChargerChambre();
            var listChambre = _chambreHelp.ListChambre();

            cbo_chambre.DataSource = listChambre;

            if (varglobale.lehotel.nom == null) return;
            foreach(var emp in chambreNames)
                grd_view.Rows.Add(emp.nochambre, emp.hotel.nom);

        }

        private void chambreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm1 = new FrmGererHotel();
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
                var unC = new chambre
                {
                    nohotel = varglobale.lehotel.nohotel,
                    nochambre = Convert.ToInt32(cbo_chambre.SelectedItem)
                };
                _chambreHelp.ListChambre();
                var lol= new chambre();
                foreach (var emp in _chambreHelp.ChargerChambre().Where(emp => emp.nochambre == unC.nochambre))
                {
                    lol = emp;
                }
                if (unC.nochambre != lol.nochambre || lol.nochambre == 0)
                {
                    varglobale.lehotel.chambre.Add(unC);
                    varglobale.connexionDb.SaveChanges();
                    FrmGererChambre_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(@"Ca existe déjà");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            var nochambre = Convert.ToInt32(cbo_chambre.SelectedItem);
            var chambreasupr = varglobale.lehotel.chambre.FirstOrDefault(chambre => chambre.nochambre == nochambre);
            varglobale.lehotel.chambre.Remove(chambreasupr);
            varglobale.connexionDb.SaveChanges();

            FrmGererChambre_Load(sender, e);

        }
    }
}

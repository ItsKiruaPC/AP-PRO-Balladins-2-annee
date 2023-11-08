using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AP_PRO_Balladins_2_annee.Classe_passerelle;

namespace AP_PRO_Balladins_2_annee
{
    public partial class FrmGererChambre : Form
    {
        private readonly ChambreDao _chambreHelp = new ChambreDao();

        public FrmGererChambre()
        {
            InitializeComponent();
        }

        //Affiche toute les informations des chambres au démarrage de l'appli
        private void FrmGererChambre_Load(object sender, EventArgs e)
        {
            grd_view.ColumnCount = 2;

            grd_view.Columns[0].HeaderText = @"Numéro";
            grd_view.Columns[1].HeaderText = @"Nom";

            grd_view.RowHeadersVisible = false;
            grd_view.AllowUserToAddRows = false;
            grd_view.AllowUserToResizeRows = false;
            grd_view.AllowUserToResizeColumns = false;

            //configure un DataGridView pour l'édition programmée, la sélection de lignes complètes, l'ajustement automatique des colonnes, et l'alignement du contenu au centre pour les lignes et les en-têtes de colonnes.
            grd_view.EditMode = DataGridViewEditMode.EditProgrammatically;
            grd_view.BackgroundColor = SystemColors.Control;
            grd_view.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grd_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grd_view.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grd_view.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grd_view.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            txt_Nom.Text = Varglobale.Lehotel.nom;
            grd_view.Rows.Clear();

            var chambreNames = _chambreHelp.ChargerChambre();
            var listChambre = ChambreDao.ListChambre();

            cbo_chambre.DataSource = listChambre;
            //Verifie que les chambres afficher dans le GRD correspondent à l'hotel 
            if (Varglobale.Lehotel.nom == null) return;
            foreach (var emp in chambreNames)
                grd_view.Rows.Add(emp.nochambre, emp.hotel.nom);
        }

        //Permet d'ajouter une chambre dans la base de donnée
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                var unC = new chambre
                {
                    nohotel = Varglobale.Lehotel.nohotel,
                    nochambre = Convert.ToInt32(cbo_chambre.SelectedItem)
                };
                ChambreDao.ListChambre();
                var uneCExiste = new chambre();
                foreach (var emp in _chambreHelp.ChargerChambre().Where(emp => emp.nochambre == unC.nochambre))
                    uneCExiste = emp;
                if (unC.nochambre != uneCExiste.nochambre || uneCExiste.nochambre == 0)
                {
                    Varglobale.Lehotel.chambre.Add(unC);
                    Varglobale.ConnexionDb.SaveChanges();
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

        //Permet de supprimer une chambre dans la base de donnée
        private void btn_Del_Click(object sender, EventArgs e)
        {
            cbo_chambre.Text = grd_view.SelectedRows[0].Cells[0].Value.ToString();
            var nochambre = Convert.ToInt32(cbo_chambre.SelectedItem);
            var chambreasupr = Varglobale.Lehotel.chambre.FirstOrDefault(chambre => chambre.nochambre == nochambre);
            Varglobale.Lehotel.chambre.Remove(chambreasupr);
            Varglobale.ConnexionDb.SaveChanges();

            FrmGererChambre_Load(sender, e);
        }

        //Permet d'éviter la saisie de caractére different de AlphaNumérique dans le ComboBox
        private void cbo_chambre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
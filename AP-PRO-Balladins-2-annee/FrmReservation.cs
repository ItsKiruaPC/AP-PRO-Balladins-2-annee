using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using AP_PRO_Balladins_2_annee.Classe_passerelle;

namespace AP_PRO_Balladins_2_annee
{
    public partial class FrmReservation : Form
    {
        public FrmReservation()
        {
            InitializeComponent();
        }
        //Permet de générer les données tel que le datagridview, la liste des chambres
        private void FrmReservation_Load(object sender, EventArgs e)
        {

            grd_liste.ColumnCount = 7;
            grd_liste.Columns[0].HeaderText = @"Date début";
            grd_liste.Columns[1].HeaderText = @"Date fin";
            grd_liste.Columns[2].HeaderText = @"Nom";
            grd_liste.Columns[3].HeaderText = @"Email";
            grd_liste.Columns[4].HeaderText = @"Code accèes";
            grd_liste.Columns[6].HeaderText = @"Nores";
            grd_liste.Columns[5].HeaderText = @"Chambre";
            grd_liste.Columns[6].Visible = false;
            grd_liste.RowHeadersVisible = false;
            grd_liste.AllowUserToAddRows = false;
            grd_liste.AllowUserToResizeRows = false;
            grd_liste.AllowUserToResizeColumns = false;
            grd_liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            chk_chambre.Items.Clear();
            lbl_Hotel.Text = Varglobale.Lehotel.nom;
            foreach (var emp in Varglobale.Lehotel.reservation )
            {
                grd_liste.Rows.Add(emp.datedeb, emp.datefin, emp.nom, emp.email, emp.codeacces,emp.chambre.Select(c=>c.nochambre.ToString()), emp.nores);
            }
            
            foreach (var emp in Varglobale.Lehotel.chambre)
            {
                chk_chambre.Items.Add(emp.nochambre);
            }
        }
        //Permet de rechercher une réservation grace a sa date de début
        private void btn_search_Click(object sender, EventArgs e)
        {
            grd_liste.Rows.Clear();
            DateTime dateDebutRecherche = datePicker.Value.Date;
            var test = Varglobale.ConnexionDb.reservation
                .Where(h => h.datedeb == dateDebutRecherche && h.nohotel == Varglobale.Lehotel.nohotel).ToList();
            foreach (var emp in test)
            {
                grd_liste.Rows.Add(emp.datedeb, emp.datefin, emp.nom, emp.email, emp.codeacces, emp.chambre.Select(c => c.nochambre.ToString()), emp.nores);
            }
        }
        //Permet de modifier la réservation en fonction de la ligne sélectionné puis on change les données
        private void btn_edit_Click(object sender, EventArgs e)
        {
            var hotel = Varglobale.Lehotel;
            int test = Convert.ToInt32(grd_liste.SelectedRows[0].Cells[5].Value);
            var reserv = Varglobale.ConnexionDb.reservation.FirstOrDefault(h =>
                h.nores == test );
            if (reserv != null)
            {
                reserv.datedeb = date_debut_edit.Value;
                reserv.datefin = date_fin_edit.Value;
                reserv.nom = txt_nom_edit.Text;
                reserv.email = txt_mail_edit.Text;
                Varglobale.ConnexionDb.SaveChanges();
                MessageBox.Show($@"Une réservation a été modifié à l'hôtel.");
                FrmReservation_Load(sender,e);
            }
            else
            {
                MessageBox.Show(@"Cette réservation n'existe pas");
            }
        }
        //Permet de génerer le code d'accées
        private int generateurMdp()
        {
            Random random = new Random();
            int min = (int)Math.Pow(10, 8 - 1);
            int max = (int)Math.Pow(10, 8) - 1;

            return random.Next(min, max + 1);
        }
        //Permet d'ajouter une reservation
        private void btn_add_Click(object sender, EventArgs e)
        {
            var hotel = Varglobale.Lehotel;
            if (hotel != null)
            {
                var uneReserv = hotel.reservation.FirstOrDefault(h =>
                    h.datedeb == date_debut.Value && h.datefin == date_fin.Value &&
                    h.nom == txt_nom.Text);
                if (uneReserv != null)
                {
                    MessageBox.Show("Cette réservation existe déjà.");
                }
                else
                {
                    
                    var nouvelleReserv = new reservation()
                    {
                        nores = Varglobale.Lehotel.reservation.Count > 0 ? Varglobale.Lehotel.reservation.Max(res => res.nores) + 1 : 1,
                        datedeb = date_debut.Value,
                        datefin = date_fin.Value,
                        nom = txt_nom.Text,
                        email = txt_mail.Text,
                        codeacces = Convert.ToDouble(generateurMdp())
                        
                    };
                    foreach (var unNoChambre in chk_chambre.CheckedItems)
                    {
                        chambre uneChambre = Varglobale.Lehotel.chambre.FirstOrDefault(chambre => chambre.nochambre.ToString() == unNoChambre.ToString());
                        nouvelleReserv.chambre.Add(uneChambre);
                    }
                    
                    Varglobale.Lehotel.reservation.Add(nouvelleReserv);
                    Varglobale.ConnexionDb.SaveChanges();
                    MessageBox.Show("Ajouté");
                    FrmReservation_Load(sender, e);
                    
                }
            }
        }
        //Permet de supprimer les réservations
        private void btn_delete_Click(object sender, EventArgs e)
        {
            var hotel = Varglobale.Lehotel;
            if (hotel != null)
            {
                DateTime dateDebut = date_debut_edit.Value.Date;
                DateTime dateFin = date_fin_edit.Value.Date;
                var uneReserv = Varglobale.ConnexionDb.reservation.FirstOrDefault(h =>
                    h.datedeb == dateDebut && h.datefin == dateFin &&
                    h.nom == txt_nom_edit.Text && h.email == txt_mail_edit.Text && h.nohotel == hotel.nohotel);
                if (uneReserv != null)
                {
                    Varglobale.ConnexionDb.reservation.Remove(uneReserv);
                    Varglobale.ConnexionDb.SaveChanges();
                    MessageBox.Show(@"Supprimé");
                    FrmReservation_Load(sender, e);
                }
            }
        }
        //Permet de séléctionner la ligne et de convertir les données dans les textbox et date
        private void grd_liste_SelectionChanged(object sender, EventArgs e)
        {
            if (grd_liste.SelectedRows.Count>0)
            {
                DataGridViewRow selectedRow = grd_liste.SelectedRows[0];
                
                string dateString1 = selectedRow.Cells[0].Value.ToString();
                string dateString2 = selectedRow.Cells[1].Value.ToString();
                txt_nom_edit.Text = selectedRow.Cells[2].Value.ToString();
                txt_mail_edit.Text = selectedRow.Cells[3].Value.ToString();

                DateTime dateValue1;
                DateTime dateValue2;
                if (DateTime.TryParse(dateString1, out dateValue1) && DateTime.TryParse(dateString2, out dateValue2))
                {
                    date_debut_edit.Value = dateValue1;
                    date_fin_edit.Value = dateValue2;
                }
                else
                {
                    MessageBox.Show(@"La date sélectionnée n'est pas valide.");
                }
            }
        }
    }
}
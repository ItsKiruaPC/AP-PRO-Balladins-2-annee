using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
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
            grd_liste.Rows.Clear();
            var numeroChambre = Varglobale.Lehotel.chambre.Select(c => c.nochambre).FirstOrDefault();
            
            foreach (var emp in Varglobale.Lehotel.reservation)
            {
                var lesnoChambre = "";
                foreach (var uneChambre in emp.chambre)
                {
                    lesnoChambre += $"{uneChambre.nochambre}, ";
                }
                grd_liste.Rows.Add(emp.datedeb, emp.datefin, emp.nom, emp.email, emp.codeacces, lesnoChambre, emp.nores);
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
            var dateDebutRecherche = datePicker.Value.Date;
            var test = Varglobale.ConnexionDb.reservation
                .Where(h => h.datedeb == dateDebutRecherche && h.nohotel == Varglobale.Lehotel.nohotel)
                .Include(reservation => reservation.chambre).ToList();
            foreach (var emp in test)
            {
                grd_liste.Rows.Add(emp.datedeb, emp.datefin, emp.nom, emp.email, emp.codeacces, emp.chambre.Select(c => c.nochambre.ToString()), emp.nores);
            }
        }
        //Permet de modifier la réservation en fonction de la ligne sélectionné puis on change les données
        private void btn_edit_Click(object sender, EventArgs e)
        {
            var hotel = Varglobale.Lehotel;
            var test = Convert.ToInt32(grd_liste.SelectedRows[0].Cells[6].Value);
            var reserv = Varglobale.ConnexionDb.reservation.FirstOrDefault(h =>
                h.nores == test );
            if (IsValidEmail(txt_mail_edit.Text))
            {
                if (reserv != null)
                {
                    reserv.datedeb = date_debut_edit.Value;
                    reserv.datefin = date_fin_edit.Value;
                    reserv.nom = txt_nom_edit.Text;
                    reserv.email = txt_mail_edit.Text;
                    Varglobale.ConnexionDb.SaveChanges();
                    MessageBox.Show(@"Une réservation a été modifié à l'hôtel.");
                    FrmReservation_Load(sender, e);
                }
                else
                {
                    MessageBox.Show(@"Cette réservation n'existe pas");
                }
            }
            else
            {
                MessageBox.Show(@"L'email n'est pas valide");
            }
        }
        //Permet de génerer le code d'accées
        private static int GenerateurMdp()
        {
            Random random = new Random();
            int min = (int)Math.Pow(10, 8 - 1);
            int max = (int)Math.Pow(10, 8) - 1;

            return random.Next(min, max + 1);
        }
        //Permet de verifier un email
        static bool IsValidEmail(string email)
        {
            string pattern = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$";
            return Regex.IsMatch(email, pattern);
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
                    MessageBox.Show(@"Cette réservation existe déjà.");
                }
                else
                {
                    if (IsValidEmail(txt_mail.Text))
                    {
                        var nouvelleReserv = new reservation()
                        {
                            nores = Varglobale.Lehotel.reservation.Count > 0 ? Varglobale.Lehotel.reservation.Max(res => res.nores) + 1 : 1,
                            datedeb = date_debut.Value,
                            datefin = date_fin.Value,
                            nom = txt_nom.Text,
                            email = txt_mail.Text,
                            codeacces = Convert.ToDouble(GenerateurMdp())
                        
                        };
                        grd_liste.Rows.Clear();
                        foreach (var unNoChambre in chk_chambre.CheckedItems)
                        {
                            chambre uneChambre = Varglobale.Lehotel.chambre.FirstOrDefault(chambre => chambre.nochambre.ToString() == unNoChambre.ToString());
                            nouvelleReserv.chambre.Add(uneChambre);
                        }
                    
                        Varglobale.Lehotel.reservation.Add(nouvelleReserv);
                        Varglobale.ConnexionDb.SaveChanges();
                        MessageBox.Show(@"Ajouté");
                        FrmReservation_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(@"L'email n'est pas valide");
                    }
                }
            }
        }
        //Permet de supprimer les réservations
        private void btn_delete_Click(object sender, EventArgs e)
        {
            var test = Convert.ToInt32(grd_liste.SelectedRows[0].Cells[6].Value);
            var test2 = Convert.ToInt32(grd_liste.SelectedRows[0].Cells[5].Value);
            var hotel = Varglobale.Lehotel;
            if (hotel != null)
            {
                DateTime dateDebut = date_debut_edit.Value.Date;
                DateTime dateFin = date_fin_edit.Value.Date;
                
                var uneReserv = Varglobale.ConnexionDb.reservation.FirstOrDefault(h =>
                    h.datedeb == dateDebut && h.datefin == dateFin &&
                    h.nom == txt_nom_edit.Text && h.email == txt_mail_edit.Text && h.nores == test);
                foreach (var uneChambre in Varglobale.Lehotel.chambre)
                {
                    uneChambre.reservation.Remove(uneReserv);
                }
                
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

        private void date_debut_Validating(object sender, CancelEventArgs e)
        {
            if (date_debut.Value > date_fin.Value)
            {
                e.Cancel = true;
                date_debut.Focus();
                errorProvider1.SetError(date_debut,"Veuillez ajouter une date plus petite que la date de fin");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(date_debut, null);
            }
        }

        private void date_fin_Validating(object sender, CancelEventArgs e)
        {
            if (date_fin.Value < date_debut.Value)
            {
                e.Cancel = true;
                date_fin.Focus();
                errorProvider1.SetError(date_fin,"Veuillez ajouter une date plus grande que la date de debut");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(date_fin, null);
            }
        }

        private void date_debut_edit_Validating(object sender, CancelEventArgs e)
        {
            if (date_debut_edit.Value >= date_fin_edit.Value)
            {
                e.Cancel = true;
                date_debut_edit.Focus();
                errorProvider1.SetError(date_debut_edit,"Veuillez ajouter une date plus petite que la date de fin");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(date_debut_edit, null);
            }
        }

        private void date_fin_edit_Validating(object sender, CancelEventArgs e)
        {
            if (date_fin_edit.Value <= date_debut_edit.Value)
            {
                e.Cancel = true;
                date_fin_edit.Focus();
                errorProvider1.SetError(date_fin_edit,"Veuillez ajouter une date plus grande que la date de debut");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(date_fin_edit, null);
            }
        }
    }
}
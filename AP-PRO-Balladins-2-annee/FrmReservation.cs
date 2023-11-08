using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text.RegularExpressions;
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

            //Permet de tout nettoyer dans le grd et listcheckbox
            chk_chambre.Items.Clear();
            grd_liste.Rows.Clear();

            //Permet de supprimer l'affichage de l'heure dans un DataGriedView -->
            grd_liste.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
            grd_liste.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            //<-- 
            //Permet d'afficher les données dans le grd et dans la listcheckbox
            var numeroChambre = Varglobale.Lehotel.chambre.Select(c => c.nochambre).FirstOrDefault();
            foreach (var emp in Varglobale.Lehotel.reservation)
                try
                {
                    var lesnoChambre =
                        emp.chambre.Aggregate("", (current, uneChambre) => current + $"{uneChambre.nochambre}, ");
                    grd_liste.Rows.Add(emp.datedeb.Value.Date, emp.datefin.Value.Date, emp.nom, emp.email,
                        emp.codeacces,
                        lesnoChambre.Substring(0, lesnoChambre.Length - 2), emp.nores);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Ceci apporte un bug car vous avez supprimer des chambres alors qu'il existe des réservations\n" +
                        "Veuillez contacter un administrateur ou alors veuillez rajouter les chambres");
                    MessageBox.Show(ex.Message);
                    throw;
                }

            foreach (var emp in Varglobale.Lehotel.chambre.OrderBy(h => h.nochambre))
                chk_chambre.Items.Add(emp.nochambre);
            //Permet que le jour de sortie soit 1 jour après
            date_fin_edit.Value = DateTime.Today.AddDays(1);
            date_fin.Value = DateTime.Today.AddDays(1);
            //Appel de la methode pour selectionner les lignes du tableau
            grd_liste_SelectionChanged(sender, e);
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
                var lesnoChambre =
                    emp.chambre.Aggregate("", (current, uneChambre) => current + $"{uneChambre.nochambre}, ");
                grd_liste.Rows.Add(emp.datedeb, emp.datefin, emp.nom, emp.email, emp.codeacces,
                    lesnoChambre.Substring(0, lesnoChambre.Length - 2),
                    emp.nores);
            }
        }

        //Permet de modifier la réservation en fonction de la ligne sélectionné puis on change les données
        private void btn_edit_Click(object sender, EventArgs e)
        {
            var hotel = Varglobale.Lehotel;
            var test = Convert.ToInt32(grd_liste.SelectedRows[0].Cells[6].Value);
            var reserv = Varglobale.ConnexionDb.reservation.FirstOrDefault(h => h.nores == test);
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
            var random = new Random();
            var min = (int)Math.Pow(10, 8 - 1);
            var max = (int)Math.Pow(10, 8) - 1;

            return random.Next(min, max + 1);
        }

        //Permet de verifier un email
        private static bool IsValidEmail(string email)
        {
            const string pattern = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$";
            return Regex.IsMatch(email, pattern);
        }

        //Permet d'ajouter une reservation
        private void btn_add_Click(object sender, EventArgs e)
        {
            var hotel = Varglobale.Lehotel;
            if (hotel == null) return;
            var uneReserv = hotel.reservation.FirstOrDefault(h =>
                h.datedeb == date_debut.Value && h.datefin == date_fin.Value && h.nom == txt_nom.Text);
            if (uneReserv != null)
            {
                MessageBox.Show(@"Cette réservation existe déjà.");
            }
            else
            {
                var fact = chk_chambre.CheckedIndices.Cast<object>().Any();
                //Suite de sécurité
                if (!string.IsNullOrEmpty(txt_nom.Text))
                {
                    if (IsValidEmail(txt_mail.Text))
                    {
                        if (date_debut.Value > date_fin.Value && date_fin.Value < date_debut.Value) return;
                        //Création de la réservation
                        if (fact)
                        {
                            var nouvelleReserv = new reservation
                            {
                                nores = Varglobale.ConnexionDb.reservation.Any()
                                    ? Varglobale.ConnexionDb.reservation.Max(res => res.nores) + 1
                                    : 1,
                                datedeb = date_debut.Value,
                                datefin = date_fin.Value,
                                nom = txt_nom.Text,
                                email = txt_mail.Text,
                                codeacces = Convert.ToDouble(GenerateurMdp())
                            };
                            grd_liste.Rows.Clear();
                            //Ajout de la chambre relier à la réservation
                            foreach (var unNoChambre in chk_chambre.CheckedItems)
                            {
                                var uneChambre = Varglobale.Lehotel.chambre.FirstOrDefault(chambre =>
                                    chambre.nochambre.ToString() == unNoChambre.ToString());
                                nouvelleReserv.chambre.Add(uneChambre);
                            }

                            Varglobale.Lehotel.reservation.Add(nouvelleReserv);
                            Varglobale.ConnexionDb.SaveChanges();
                            MessageBox.Show(@"Ajouté");
                            FrmReservation_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show(@"Il n'y a pas de chambre séléctionner");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Il manque l'email");
                    }
                }
                else
                {
                    MessageBox.Show(@"Il manque le nom");
                }
            }
        }

        //Permet de supprimer les réservations
        private void btn_delete_Click(object sender, EventArgs e)
        {
            var test = Convert.ToInt32(grd_liste.SelectedRows[0].Cells[6].Value);
            var hotel = Varglobale.Lehotel;
            if (hotel == null) return;
            var dateDebut = date_debut_edit.Value;
            var dateFin = date_fin_edit.Value;
            var uneReserv = Varglobale.ConnexionDb.reservation.FirstOrDefault(h =>
                h.datedeb == dateDebut && h.datefin == dateFin && h.nom == txt_nom_edit.Text &&
                h.email == txt_mail_edit.Text && h.nores == test);
            foreach (var uneChambre in Varglobale.Lehotel.chambre) uneChambre.reservation.Remove(uneReserv);
            if (uneReserv == null) return;
            Varglobale.ConnexionDb.reservation.Remove(uneReserv);
            Varglobale.ConnexionDb.SaveChanges();
            FrmReservation_Load(sender, e);
        }

        //Permet de séléctionner la ligne et de convertir les données dans les textbox et date
        private void grd_liste_SelectionChanged(object sender, EventArgs e)
        {
            if (grd_liste.SelectedRows.Count > 0)
            {
                var selectedRow = grd_liste.SelectedRows[0];

                var dateString1 = selectedRow.Cells[0].Value.ToString();
                var dateString2 = selectedRow.Cells[1].Value.ToString();
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

        //Permet d'instancer la date de début de la reservation
        private void date_debut_Validating(object sender, CancelEventArgs e)
        {
            if (date_debut.Value > date_fin.Value)
            {
                e.Cancel = true;
                date_debut.Focus();
                errorProvider1.SetError(date_debut, "Veuillez ajouter une date plus petite que la date de fin");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(date_debut, null);
            }
        }

        //Permet d'instancer la date de fin de la reservation
        private void date_fin_Validating(object sender, CancelEventArgs e)
        {
            if (date_fin.Value < date_debut.Value)
            {
                e.Cancel = true;
                date_fin.Focus();
                errorProvider1.SetError(date_fin, "Veuillez ajouter une date plus grande que la date de debut");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(date_fin, null);
            }
        }

        //Verifie que la date de début est inferieur à la date de fin
        private void date_debut_edit_Validating(object sender, CancelEventArgs e)
        {
            if (date_debut_edit.Value >= date_fin_edit.Value)
            {
                e.Cancel = true;
                date_debut_edit.Focus();
                errorProvider1.SetError(date_debut_edit, "Veuillez ajouter une date plus petite que la date de fin");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(date_debut_edit, null);
            }
        }

        //Vérifie que la date de fin soit supérieur à la date de début
        private void date_fin_edit_Validating(object sender, CancelEventArgs e)
        {
            if (date_fin_edit.Value <= date_debut_edit.Value)
            {
                e.Cancel = true;
                date_fin_edit.Focus();
                errorProvider1.SetError(date_fin_edit, "Veuillez ajouter une date plus grande que la date de debut");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(date_fin_edit, null);
            }
        }

        //Permet de re-afficher toutes les réservations
        private void btn_reinit_Click(object sender, EventArgs e)
        {
            FrmReservation_Load(sender, e);
        }

        //Permet de selectionner toutes les chambres
        private void btn_tout_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < chk_chambre.Items.Count; i++) chk_chambre.SetItemChecked(i, true);
        }
    }
}
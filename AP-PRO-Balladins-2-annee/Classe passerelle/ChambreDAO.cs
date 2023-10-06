using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_PRO_Balladins_2_annee.Classe_passerelle
{
    internal class ChambreDAO
    {
        public List<chambre> ChargerChambre()
        {
            
            try
            {
                // Récupérez tous les équipements de la base de données
                return varglobale.lehotel.chambre.OrderBy(h => h.nochambre).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}");
                return null;
            }
        }
        public List<int> ListChambre()
        {
            ConnexionDb contexte = new ConnexionDb();
            try
            {
                // Récupérez tous les équipements de la base de données
                return contexte.chambre.Select(h => h.nochambre).Distinct().OrderBy(t => t).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}");
                return null;
            }
        }
    }
}

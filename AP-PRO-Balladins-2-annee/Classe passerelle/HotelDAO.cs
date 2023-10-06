using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_PRO_Balladins_2_annee.Classe_passerelle
{
    public class HotelDAO
    {
        public List<hotel> ChargerHotel()
        {

           ConnexionDb context = new ConnexionDb();
            try
                {
                // Remplacez "Hotels" par le nom de votre entité représentant les hôtels
                return context.hotel.ToList();
                }
                catch (Exception ex)
                {
                    // Gérer les erreurs selon vos besoins
                    Console.WriteLine($"Erreur lors du chargement des noms d'hôtels : {ex.Message}");
                    return null;
                }
            
            
        }
        public List<string> ListHotel()
        {

            ConnexionDb context = new ConnexionDb();
            try
            {
                // Remplacez "Hotels" par le nom de votre entité représentant les hôtels
                return context.hotel.Select(h=>h.nom).ToList();
            }
            catch (Exception ex)
            {
                // Gérer les erreurs selon vos besoins
                Console.WriteLine($"Erreur lors du chargement des noms d'hôtels : {ex.Message}");
                return null;
            }


        }
    }
}

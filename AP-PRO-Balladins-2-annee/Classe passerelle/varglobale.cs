using AP_PRO_Balladins_2_annee.Classe_Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_PRO_Balladins_2_annee
{
    internal class varglobale
    {
        public static hotel lehotel;
        List<hotel> leshotels;
        public static equipement equipement;
        public static equiper equiper;
        public static reserv reserv;
        public static reservation reservation;
        public static photo photo;
        public static ConnexionDb connexionDb = new ConnexionDb();
    }
}

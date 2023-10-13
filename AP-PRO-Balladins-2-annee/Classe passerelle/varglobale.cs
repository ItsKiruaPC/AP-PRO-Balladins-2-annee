using System.Security;

namespace AP_PRO_Balladins_2_annee
{
    public class varglobale
    {
        public static hotel lehotel;
        public static ConnexionDb connexionDb = new ConnexionDb();
        public static FrmPrincipal frm1 = new FrmPrincipal();
        public static FrmConnexion frm2 = new FrmConnexion();
        public static FrmGererHotel frm3 = new FrmGererHotel();
        public static FrmGererChambre frm4 = new FrmGererChambre();
        public static bool ouverture;
    }
}

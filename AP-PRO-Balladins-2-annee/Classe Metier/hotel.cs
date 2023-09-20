using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_PRO_Balladins_2_annee.Classe_Metier
{
    public class hotel
    {

        public List<hotel> leshotels()
        {
            foreach (var emp in leshotels())
            {
                leshotels().Add(emp);
            }
            return leshotels();
        }
        public void hotelexiste()
        {
           
        }

    }
}

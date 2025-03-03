using DiGi.BDOT10k.Enums;
using DiGi.BDOT10k.Interfaces;
using DiGi.GML.Classes;

namespace DiGi.BDOT10k.Classes
{
    public class OT_ADJA_A : OT_PodzialTerytorialny, IOT_PowierzchniowyObiektGeometryczny
    {
        public string identyfikatorPRG { get; set; }

        public string identyfikatorTERYTjednostki { get; set; }

        public string? idTERYTjednostkiNadrzednej { get; set; }

        public OT_RodzajJednostkiAdministracyjnej rodzaj { get; set; }

        public Surface geometria{ get; set; }

        public OT_ADJA_A() 
        {
            
        }
    }
}

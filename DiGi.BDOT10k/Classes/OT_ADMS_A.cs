using DiGi.BDOT10k.Enums;
using DiGi.BDOT10k.Interfaces;
using DiGi.GML.Classes;

namespace DiGi.BDOT10k.Classes
{
    public class OT_ADMS_A : OT_PodzialTerytorialny, IOT_PowierzchniowyObiektGeometryczny
    {
        public string? identyfikatorSIMC { get; set; }

        public string identyfikatorTERC { get; set; }

        public OT_RodzajMiejscowosci rodzaj { get; set; }

        public uint? liczbaMieszkancow { get; set; }

        public string identyfikatorPRNG { get; set; }

        public Surface geometria{ get; set; }

        public OT_ADMS_A() 
        {
            
        }
    }
}

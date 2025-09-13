using DiGi.BDOT10k.Enums;
using DiGi.BDOT10k.Interfaces;
using DiGi.GML.Classes;

namespace DiGi.BDOT10k.Classes
{
    public class OT_ADMS_A : OT_PodzialTerytorialny, IOT_PowierzchniowyObiektGeometryczny
    {
        public string? identyfikatorSIMC { get; set; } = null;

        public string identyfikatorTERC { get; set; } = string.Empty;

        public OT_RodzajMiejscowosci rodzaj { get; set; } = OT_RodzajMiejscowosci.inny_obiekt;

        public uint? liczbaMieszkancow { get; set; } = null;

        public string identyfikatorPRNG { get; set; } = string.Empty;

        public Surface geometria{ get; set; } = new Polygon();

        public OT_ADMS_A() 
        {
            
        }
    }
}

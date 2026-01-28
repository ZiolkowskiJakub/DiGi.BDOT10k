using DiGi.BDOT10k.Enums;
using DiGi.BDOT10k.Interfaces;
using DiGi.GML.Classes;

namespace DiGi.BDOT10k.Classes
{
    public class OT_ADJA_A : OT_PodzialTerytorialny, IOT_PowierzchniowyObiektGeometryczny
    {
        public string identyfikatorPRG { get; set; } = string.Empty;

        public string identyfikatorTERYTjednostki { get; set; } = string.Empty;

        public string? idTERYTjednostkiNadrzednej { get; set; } = null;

        public OT_RodzajJednostkiAdministracyjnej rodzaj { get; set; } = OT_RodzajJednostkiAdministracyjnej.panstwo;

        public Surface geometria { get; set; } = new Polygon();

        public OT_ADJA_A()
        {
        }
    }
}
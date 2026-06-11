using DiGi.BDOT10k.Enums;
using DiGi.BDOT10k.Interfaces;
using DiGi.GML.Classes;

namespace DiGi.BDOT10k.Classes
{
    /// <summary>
    /// Reprezentuje obiekt jednostki administracyjnej w ramach podziału terytorialnego (BDOT10k).
    /// </summary>
    public class OT_ADJA_A : OT_PodzialTerytorialny, IOT_PowierzchniowyObiektGeometryczny
    {
        /// <summary>
        /// Identyfikator PRG jednostki administracyjnej.
        /// </summary>
        public string identyfikatorPRG { get; set; } = string.Empty;

        /// <summary>
        /// Identyfikator TERYT jednostki administracyjnej.
        /// </summary>
        public string identyfikatorTERYTjednostki { get; set; } = string.Empty;

        /// <summary>
        /// Identyfikator TERYT jednostki nadrzędnej.
        /// </summary>
        public string? idTERYTjednostkiNadrzednej { get; set; } = null;

        /// <summary>
        /// Rodzaj jednostki administracyjnej.
        /// </summary>
        public OT_RodzajJednostkiAdministracyjnej rodzaj { get; set; } = OT_RodzajJednostkiAdministracyjnej.panstwo;

        /// <summary>
        /// Geometria powierzchniowa obiektu.
        /// </summary>
        public Surface geometria { get; set; } = new Polygon();

        /// <summary>
        /// Inicjalizuje nową instancję klasy <see cref="OT_ADJA_A"/>.
        /// </summary>
        public OT_ADJA_A()
        {
        }
    }
}
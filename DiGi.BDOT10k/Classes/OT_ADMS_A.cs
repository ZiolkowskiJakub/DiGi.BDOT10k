using DiGi.BDOT10k.Enums;
using DiGi.BDOT10k.Interfaces;
using DiGi.GML.Classes;

namespace DiGi.BDOT10k.Classes
{
    /// <summary>
    /// Reprezentuje obiekt administracyjny typu A w ramach podziału terytorialnego BDOT10k.
    /// </summary>
    public class OT_ADMS_A : OT_PodzialTerytorialny, IOT_PowierzchniowyObiektGeometryczny
    {
        /// <summary>
        /// Identyfikator SIMC (System Identyfikacji Miejscowości i Członów).
        /// </summary>
        public string? identyfikatorSIMC { get; set; } = null;

        /// <summary>
        /// Identyfikator TERC.
        /// </summary>
        public string identyfikatorTERC { get; set; } = string.Empty;

        /// <summary>
        /// Rodzaj miejscowości.
        /// </summary>
        public OT_RodzajMiejscowosci rodzaj { get; set; } = OT_RodzajMiejscowosci.inny_obiekt;

        /// <summary>
        /// Liczba mieszkańców.
        /// </summary>
        public uint? liczbaMieszkancow { get; set; } = null;

        /// <summary>
        /// Identyfikator PRNG.
        /// </summary>
        public string identyfikatorPRNG { get; set; } = string.Empty;

        /// <summary>
        /// Geometria powierzchniowa obiektu.
        /// </summary>
        public Surface geometria { get; set; } = new Polygon();

        /// <summary>
        /// Inicjalizuje nową instancję klasy <see cref="OT_ADMS_A"/>.
        /// </summary>
        public OT_ADMS_A()
        {
        }
    }
}
using DiGi.BDOT10k.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.BDOT10k.Geometry.Classes
{
    /// <summary>
    /// Reprezentuje obiekt geometryczny powierzchniowy typu BUBD_A w standardzie BDOT10k.
    /// </summary>
    public class BUBD_A : PowierzchniowyObiektGeometryczny<OT_BUBD_A>
    {
        /// <summary>
        /// Inicjalizuje nową instancję klasy <see cref="BUBD_A"/>.
        /// </summary>
        /// <param name="oT_PowierzchniowyObiektGeometryczny">Obiekt danych wejściowych dla powierzchniowego obiektu geometrycznego.</param>
        /// <param name="surfaceAppearance">Wygląd powierzchni obiektu.</param>
        public BUBD_A(OT_BUBD_A? oT_PowierzchniowyObiektGeometryczny, ISurfaceAppearance? surfaceAppearance)
            : base(oT_PowierzchniowyObiektGeometryczny, surfaceAppearance)
        {
        }
    }
}
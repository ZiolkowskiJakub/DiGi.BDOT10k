using DiGi.BDOT10k.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;

namespace DiGi.BDOT10k.Geometry.Classes
{
    /// <summary>
    /// Reprezentuje powierzchniowy obiekt geometryczny typu ADMS_A zgodnie ze standardem BDOT10k.
    /// </summary>
    public class ADMS_A : PowierzchniowyObiektGeometryczny<OT_ADMS_A>
    {
        /// <summary>
        /// Inicjalizuje nową instancję klasy <see cref="ADMS_A"/>.
        /// </summary>
        /// <param name="oT_PowierzchniowyObiektGeometryczny">Obiekt danych wejściowych dla obiektu powierzchniowego.</param>
        /// <param name="surfaceAppearance">Wygląd powierzchni obiektu.</param>
        public ADMS_A(OT_ADMS_A? oT_PowierzchniowyObiektGeometryczny, ISurfaceAppearance? surfaceAppearance)
            : base(oT_PowierzchniowyObiektGeometryczny, surfaceAppearance)
        {
        }

        /// <summary>
        /// Pobiera liczbę mieszkańców przypisaną do danego obiektu.
        /// </summary>
        /// <value>Liczba mieszkańców jako wartość typu uint lub null, jeśli nie jest określona.</value>
        public uint? liczbaMieszkancow
        {
            get
            {
                return oT_PowierzchniowyObiektGeometryczny?.liczbaMieszkancow;
            }
        }
    }
}
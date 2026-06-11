using DiGi.BDOT10k.Classes;
using DiGi.BDOT10k.Interfaces;
using DiGi.BDOT10k.Geometry.Classes;
using DiGi.BDOT10k.Geometry.Interfaces;

namespace DiGi.BDOT10k.Geometry
{
    public static partial class Convert
    {
        /// <summary>
        /// Konwertuje obiekt geometryczny z formatu transferowego (IOT) na wewnętrzny format DiGi.
        /// </summary>
        /// <param name="oT_ObiektGeometryczny">Obiekt geometryczny w formacie transferowym do konwersji.</param>
        /// <returns>Odpowiednik obiektu w formacie DiGi lub <see langword="null"/>, jeśli wejściowy obiekt jest nullem.</returns>
        /// <exception cref="System.NotImplementedException">Rzucane, gdy typ przekazanego obiektu nie jest obsługiwany przez konwerter.</exception>
        public static IObiektGeometryczny? ToDiGi(this IOT_ObiektGeometryczny? oT_ObiektGeometryczny)
        {
            if (oT_ObiektGeometryczny == null)
            {
                return null;
            }

            if (oT_ObiektGeometryczny is OT_ADMS_A oT_ADMS_A)
            {
                return new ADMS_A(oT_ADMS_A, null);
            }
            else if (oT_ObiektGeometryczny is OT_BUBD_A oT_BUBD_A)
            {
                return new BUBD_A(oT_BUBD_A, null);
            }

            throw new System.NotImplementedException();
        }
    }
}
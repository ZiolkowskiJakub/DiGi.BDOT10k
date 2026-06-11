using DiGi.BDOT10k.Geometry.Classes;
using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.BDOT10k.Geometry
{
    public static partial class Query
    {
        /// <summary>
        /// Oblicza liczbę mieszkańców dla określonego obiektu <see cref="ADMS_A"/> na podstawie dostarczonej kolekcji obiektów, 
        /// uwzględniając relacje przestrzenne oraz hierarchię obszarów (odejmowanie populacji mniejszych obszarów zawartych w większych).
        /// </summary>
        /// <param name="aDMS_As">Kolekcja obiektów typu <see cref="ADMS_A"/> służąca do analizy przestrzennej i obliczeń.</param>
        /// <param name="aDMS_A">Obiekt typu <see cref="ADMS_A"/>, dla którego wyznaczana jest liczba mieszkańców.</param>
        /// <returns>Liczba mieszkańców jako wartość <see cref="uint"/> lub null, jeśli dane są niedostępne lub nie spełniają kryteriów.</returns>
        public static uint? LiczbaMieszkancow(this IEnumerable<ADMS_A> aDMS_As, ADMS_A aDMS_A)
        {
            if (aDMS_As == null || aDMS_A == null)
            {
                return null;
            }

            List<ADMS_A> aDMS_As_LiczbaMieszkancow = [.. aDMS_As];
            aDMS_As_LiczbaMieszkancow.RemoveAll(x => x.OT_PowierzchniowyObiektGeometryczny?.liczbaMieszkancow == null || !x.OT_PowierzchniowyObiektGeometryczny.liczbaMieszkancow.HasValue || x.OT_PowierzchniowyObiektGeometryczny.liczbaMieszkancow.Value == 0);
            if (aDMS_As_LiczbaMieszkancow == null || aDMS_As_LiczbaMieszkancow.Count == 0)
            {
                return null;
            }

            List<ADMS_A> aDMS_As_Inside = aDMS_As_LiczbaMieszkancow.FindAll(x => aDMS_A.BoundingBox2D is BoundingBox2D boundingBox2D && boundingBox2D.Inside(x.InternalPoint2D) && aDMS_A.Geometry is PolygonalFace2D polygonalFace2D && polygonalFace2D.Inside(x.InternalPoint2D));
            aDMS_As_Inside.RemoveAll(x => x.Area > aDMS_A.Area);
            if (aDMS_As_Inside == null || aDMS_As_Inside.Count == 0)
            {
                return null;
            }

            if (aDMS_As_Inside.Count == 1)
            {
                return aDMS_As_Inside[0].liczbaMieszkancow;
            }

            aDMS_As_Inside.Sort((x, y) => y.Area.CompareTo(x.Area));

            ADMS_A aDMS_A_Temp = aDMS_As_Inside[0];
            aDMS_As_Inside.RemoveAt(0);

            long @long = System.Convert.ToInt64(aDMS_A_Temp.liczbaMieszkancow!.Value);
            foreach (ADMS_A aDMS_A_Inside in aDMS_As_Inside)
            {
                @long -= aDMS_A_Inside.liczbaMieszkancow!.Value;
                if (@long <= 0)
                {
                    return aDMS_A_Temp.liczbaMieszkancow.Value;
                }
            }

            return System.Convert.ToUInt32(@long);
        }
    }
}
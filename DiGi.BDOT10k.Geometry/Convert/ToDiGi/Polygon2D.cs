using DiGi.Geometry.Planar.Classes;
using System.Collections.Generic;

namespace DiGi.BDOT10k.Geometry
{
    public static partial class Convert
    {
        /// <summary>
        /// Konwertuje obiekt pierścienia liniowego GML na obiekt Polygon2D.
        /// </summary>
        /// <param name="linearRing">Obiekt pierścienia liniowego GML do konwersji.</param>
        /// <returns>Obiekt <see cref="Polygon2D"/> reprezentujący dany pierścień liniowy, lub <c>null</c>, jeśli wejście jest nieprawidłowe, puste lub zawiera nieparzystą liczbę współrzędnych.</returns>
        public static Polygon2D? ToDiGi(this GML.Classes.LinearRing? linearRing)
        {
            if (linearRing == null)
            {
                return null;
            }

            List<double> values = linearRing.posList;
            if (values == null)
            {
                return null;
            }

            int count = values.Count;

            if (count == 0 || count % 2 != 0)
            {
                return null;
            }

            List<Point2D> point2Ds = [];
            for (int i = 0; i < values.Count; i += 2)
            {
                point2Ds.Add(new Point2D(values[i], values[i + 1]));
            }

            return new Polygon2D(point2Ds);
        }
    }
}
using DiGi.BDOT10k.Geometry.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using System;
using System.Collections.Generic;

namespace DiGi.BDOT10k.Geometry
{
    public static partial class Query
    {
        /// <summary>
        /// Wyszukuje najbardziej dopasowany obiekt ADMS_A dla podanego obiektu BUBD_A na podstawie analizy przestrzennej, 
        /// sprawdzając zawarcie punktu wewnętrznego, punktów krawędzi zewnętrznej lub najbliższą odległość.
        /// </summary>
        /// <param name="aDMS_As">Kolekcja obiektów ADMS_A do przeszukania.</param>
        /// <param name="bUBD_A">Obiekt BUBD_A służący jako punkt odniesienia dla wyszukiwania.</param>
        /// <returns>Najbardziej dopasowany obiekt ADMS_A lub <c>null</c>, jeśli nie znaleziono pasującego obiektu lub przekazano nieprawidłowe argumenty.</returns>
        public static ADMS_A? ADMS_A(this IEnumerable<ADMS_A>? aDMS_As, BUBD_A? bUBD_A)
        {
            if (aDMS_As == null || bUBD_A == null)
            {
                return null;
            }

            Point2D? point2D = bUBD_A.InternalPoint2D;
            if (point2D == null)
            {
                return null;
            }

            List<ADMS_A> aDMS_As_Temp = [.. aDMS_As];

            List<ADMS_A> aDMS_As_BUBD_A = aDMS_As_Temp.FindAll(x => x?.BoundingBox2D != null && x.BoundingBox2D.InRange(point2D) && x.Geometry is PolygonalFace2D polygonalFace2D && polygonalFace2D.InRange(point2D));

            if (aDMS_As_BUBD_A == null || aDMS_As_BUBD_A.Count == 0)
            {
                BoundingBox2D? boundingBox2D = bUBD_A.BoundingBox2D;
                if (boundingBox2D == null)
                {
                    return null;
                }

                List<Point2D>? point2Ds = bUBD_A.Geometry?.ExternalEdge?.GetPoints();
                if (point2Ds == null || point2Ds.Count == 0)
                {
                    return null;
                }

                foreach (Point2D point2D_Temp in point2Ds)
                {
                    aDMS_As_BUBD_A = aDMS_As_Temp.FindAll(x => x.BoundingBox2D is BoundingBox2D boundingBox2D_Temp && boundingBox2D_Temp.InRange(point2D_Temp) && x.Geometry is PolygonalFace2D polygonalFace2D && polygonalFace2D.InRange(point2D_Temp));
                    if (aDMS_As_BUBD_A != null && aDMS_As_BUBD_A.Count > 0)
                    {
                        point2D = point2D_Temp;
                        break;
                    }
                }
            }

            if (aDMS_As_BUBD_A == null || aDMS_As_BUBD_A.Count == 0)
            {
                List<Tuple<double, ADMS_A>> tuples_ADMS_A = aDMS_As_Temp.ConvertAll(x => new Tuple<double, ADMS_A>(x.Geometry?.ExternalEdge is IPolygonal2D polygonal2D ? polygonal2D.Distance(point2D) : double.MaxValue, x));
                tuples_ADMS_A.Sort((x, y) => x.Item1.CompareTo(y.Item1));

                Point2D? point2D_Temp = tuples_ADMS_A[0].Item2.Geometry?.ExternalEdge?.ClosestPoint(point2D);
                aDMS_As_BUBD_A = aDMS_As_Temp.FindAll(x => x.BoundingBox2D is BoundingBox2D boundingBox2D && boundingBox2D.InRange(point2D_Temp) && x.Geometry is PolygonalFace2D polygonalFace2D && polygonalFace2D.InRange(point2D_Temp));
                if (aDMS_As_BUBD_A == null || aDMS_As_BUBD_A.Count == 0)
                {
                    aDMS_As_BUBD_A = [tuples_ADMS_A[0].Item2];
                }
            }

            if (aDMS_As_BUBD_A == null || aDMS_As_BUBD_A.Count == 0)
            {
                return null;
            }

            if (aDMS_As_BUBD_A.Count > 1)
            {
                aDMS_As_BUBD_A.Sort((x, y) => x.Area.CompareTo(y.Area));
            }

            return aDMS_As_BUBD_A[0];
        }
    }
}
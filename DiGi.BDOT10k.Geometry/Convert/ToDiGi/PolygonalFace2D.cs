using DiGi.Geometry.Planar.Classes;
using DiGi.GML.Classes;
using System.Collections.Generic;

namespace DiGi.BDOT10k.Geometry
{
    public static partial class Convert
    {
        /// <summary>
        /// Konwertuje obiekt powierzchni (Surface) z modelu GML na reprezentację PolygonalFace2D w bibliotece DiGi.Geometry.
        /// </summary>
        /// <param name="surface">Powierzchnia źródłowa do konwersji.</param>
        /// <returns>Obiekt PolygonalFace2D będący wynikiem konwersji lub null, jeśli powierzchnia źródłowa jest nullem lub nie może zostać przekonwertowana.</returns>
        public static PolygonalFace2D? ToDiGi(this Surface? surface)
        {
            if (surface == null)
            {
                return null;
            }

            if (surface is Polygon polygon)
            {
                Polygon2D? externalPolygon2D = polygon.exterior?.ToDiGi();
                if (externalPolygon2D == null)
                {
                    return null;
                }

                List<Polygon2D>? internalPolygon2Ds = null;
                if (polygon.interior != null)
                {
                    internalPolygon2Ds = [];
                    foreach (LinearRing linearRing in polygon.interior)
                    {
                        Polygon2D? internalPolygon2D = linearRing?.ToDiGi();
                        if (internalPolygon2D == null)
                        {
                            continue;
                        }

                        internalPolygon2Ds.Add(internalPolygon2D);
                    }
                }

                return DiGi.Geometry.Planar.Create.PolygonalFace2D(externalPolygon2D, internalPolygon2Ds);
            }

            throw new System.NotImplementedException();
        }
    }
}
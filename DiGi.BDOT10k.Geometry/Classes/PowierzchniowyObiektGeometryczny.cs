using DiGi.BDOT10k.Interfaces;
using DiGi.BDOT10k.Geometry.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Classes;

namespace DiGi.BDOT10k.Geometry.Classes
{
    /// <summary>
    /// Represents an abstract surface geometric object in the BDOT10k standard.
    /// </summary>
    /// <typeparam name="T">The type of the input data object implementing the <see cref="IOT_PowierzchniowyObiektGeometryczny"/> interface.</typeparam>
    public abstract class PowierzchniowyObiektGeometryczny<T> : VisualPolygonalFace2D, IObiektGeometryczny<PolygonalFace2D, ISurfaceAppearance> where T : IOT_PowierzchniowyObiektGeometryczny
    {
        protected T? oT_PowierzchniowyObiektGeometryczny;

        private double area = double.NaN;
        private BoundingBox2D? boundingBox2D = null;
        private Point2D? internalPoint2D = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PowierzchniowyObiektGeometryczny{T}"/> class.
        /// </summary>
        /// <param name="oT_PowierzchniowyObiektGeometryczny">The input data object containing the surface geometry.</param>
        /// <param name="surfaceAppearance">The surface appearance of the object.</param>
        public PowierzchniowyObiektGeometryczny(T? oT_PowierzchniowyObiektGeometryczny, ISurfaceAppearance? surfaceAppearance)
            : base(Convert.ToDiGi(oT_PowierzchniowyObiektGeometryczny?.geometria), surfaceAppearance)
        {
            this.oT_PowierzchniowyObiektGeometryczny = GML.Query.Clone(oT_PowierzchniowyObiektGeometryczny);
        }

        /// <summary> Gets a clone of the input data object associated with this geometric object. </summary>
        public T? OT_PowierzchniowyObiektGeometryczny
        {
            get
            {
                return GML.Query.Clone(oT_PowierzchniowyObiektGeometryczny);
            }
        }

        /// <summary>
        /// Gets the type of the input data object associated with this geometric object.
        /// </summary>
        /// <returns>The type of the input data object, or <see langword="null"/> if the object is not assigned.</returns>
        public System.Type? GetUnderlyingType()
        {
            return oT_PowierzchniowyObiektGeometryczny?.GetType();
        }

        /// <summary> Gets the area of the geometric object. </summary>
        public double Area
        {
            get
            {
                if (double.IsNaN(area) && Geometry != null)
                {
                    area = Geometry.GetArea();
                }

                return area;
            }
        }

        /// <summary> Gets the bounding box of the object in 2D space. </summary>
        public BoundingBox2D? BoundingBox2D
        {
            get
            {
                if (boundingBox2D == null && Geometry != null)
                {
                    boundingBox2D = Geometry.GetBoundingBox();
                }

                return boundingBox2D == null ? null : new BoundingBox2D(boundingBox2D);
            }
        }

        /// <summary> Gets the internal point of the geometric object. </summary>
        public Point2D? InternalPoint2D
        {
            get
            {
                if (internalPoint2D == null && Geometry != null)
                {
                    internalPoint2D = Geometry.GetInternalPoint();
                }

                return internalPoint2D == null ? null : new Point2D(internalPoint2D);
            }
        }
    }
}

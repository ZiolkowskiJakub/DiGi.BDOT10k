using DiGi.GML.Classes;

namespace DiGi.BDOT10k.Interfaces
{
    public interface IOT_ObiektGeometryczny<T> : GML.Interfaces.IAbstractGML where T : GeometricPrimitive
    {
        public T geometria { get; set; }
    }
}

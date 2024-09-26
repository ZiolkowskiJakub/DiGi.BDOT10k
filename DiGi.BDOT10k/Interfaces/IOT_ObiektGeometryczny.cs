using DiGi.GML.Classes;

namespace DiGi.BDOT10k.Interfaces
{
    public interface IOT_ObiektGeometryczny : GML.Interfaces.IAbstractGML
    {

    }

    public interface IOT_ObiektGeometryczny<T> : IOT_ObiektGeometryczny where T : GeometricPrimitive
    {
        public T geometria { get; set; }
    }
}

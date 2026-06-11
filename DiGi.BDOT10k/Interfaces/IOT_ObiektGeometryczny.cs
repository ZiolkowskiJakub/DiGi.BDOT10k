using DiGi.GML.Classes;

namespace DiGi.BDOT10k.Interfaces
{
    /// <summary>
    /// Interfejs definiujący podstawowe właściwości obiektu geometrycznego w standardzie BDOT10k.
    /// </summary>
    public interface IOT_ObiektGeometryczny : GML.Interfaces.IAbstractGML
    {
    }

    /// <summary>
    /// Generyczny interfejs definiujący obiekt geometryczny z określonym typem geometrii.
    /// </summary>
    /// <typeparam name="T">Typ prymitywu geometrycznego implementującego klasę GeometricPrimitive.</typeparam>
    public interface IOT_ObiektGeometryczny<T> : IOT_ObiektGeometryczny where T : GeometricPrimitive
    {
        /// <summary>
        /// Pobiera lub ustawia geometrię obiektu.
        /// </summary>
        public T geometria { get; set; }
    }
}
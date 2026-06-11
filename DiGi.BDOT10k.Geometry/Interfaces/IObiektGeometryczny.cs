using DiGi.Geometry.Planar.Interfaces;
using DiGi.Geometry.Visual.Core.Interfaces;
using DiGi.Geometry.Visual.Planar.Interfaces;
using System;

namespace DiGi.BDOT10k.Geometry.Interfaces
{
    /// <summary>
    /// Definiuje podstawowy interfejs dla obiektów geometrycznych w systemie BDOT10k.
    /// </summary>
    public interface IObiektGeometryczny : IVisual2D
    {
        /// <summary>
        /// Pobiera typ bazowy obiektu geometrycznego.
        /// </summary>
        /// <returns>Typ obiektu geometrycznego lub <see langword="null"/>, jeśli nie jest określony.</returns>
        Type? GetUnderlyingType();
    }

    /// <summary>
    /// Definiuje generyczny interfejs dla obiektów geometrycznych z określonym typem geometrii oraz wyglądu.
    /// </summary>
    /// <typeparam name="T">Typ geometrii 2D implementujący interfejs <see cref="IGeometry2D"/>.</typeparam>
    /// <typeparam name="X">Typ wyglądu implementujący interfejs <see cref="IAppearance"/>.</typeparam>
    public interface IObiektGeometryczny<T, X> : IObiektGeometryczny, IVisual2D<T, X> where T : IGeometry2D where X : IAppearance
    {
    }
}
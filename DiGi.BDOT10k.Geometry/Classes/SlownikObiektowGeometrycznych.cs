using DiGi.BDOT10k.Geometry.Interfaces;
using System;
using System.Collections.Generic;

namespace DiGi.BDOT10k.Geometry.Classes
{
    /// <summary>
    /// Klasa reprezentująca słownik obiektów geometrycznych, umożliwiający przechowywanie i wyszukiwanie obiektów według ich typu.
    /// </summary>
    public class SlownikObiektowGeometrycznych
    {
        private readonly Dictionary<Type, List<IObiektGeometryczny>> dictionary = [];

        /// <summary>
        /// Inicjalizuje nową instancję klasy <see cref="SlownikObiektowGeometrycznych"/>.
        /// </summary>
        public SlownikObiektowGeometrycznych()
        {
        }

        /// <summary>
        /// Dodaje obiekt geometryczny do słownika, grupując go według jego typu.
        /// </summary>
        /// <param name="obiektGeometryczny">Obiekt geometryczny do dodania.</param>
        /// <returns>Wartość <see langword="true"/>, jeśli obiekt został pomyślnie dodany; w przeciwnym razie <see langword="false"/> (np. gdy przekazano wartość <see langword="null"/>).</returns>
        public bool Add(IObiektGeometryczny obiektGeometryczny)
        {
            if (obiektGeometryczny == null)
            {
                return false;
            }

            Type type = obiektGeometryczny.GetType();

            if (!dictionary.TryGetValue(type, out List<IObiektGeometryczny> obiektyGeometryczne) || obiektyGeometryczne == null)
            {
                obiektyGeometryczne = [];
                dictionary[type] = obiektyGeometryczne;
            }

            obiektyGeometryczne.Add(obiektGeometryczny);
            return true;
        }

        /// <summary>
        /// Pobiera listę wszystkich obiektów geometrycznych danego typu, które spełniają określone kryterium filtrowania.
        /// </summary>
        /// <typeparam name="T">Typ obiektu geometrycznego, który ma zostać pobrany.</typeparam>
        /// <param name="func">Opcjonalna funkcja filtrująca obiekty typu <typeparamref name="T"/>.</param>
        /// <returns>Lista obiektów typu <typeparamref name="T"/> spełniających kryteria lub <see langword="null"/>, jeśli słownik jest nieprawidłowy.</returns>
        public List<T>? GetObiektyGeometryczne<T>(Func<T, bool>? func = null) where T : IObiektGeometryczny
        {
            if (dictionary == null)
            {
                return null;
            }

            Type type = typeof(T);

            List<T> result = [];
            foreach (KeyValuePair<Type, List<IObiektGeometryczny>> keyValuePair in dictionary)
            {
                if (!type.IsAssignableFrom(keyValuePair.Key))
                {
                    continue;
                }

                foreach (IObiektGeometryczny obiektGeometryczny in keyValuePair.Value)
                {
                    if (obiektGeometryczny is not T)
                    {
                        continue;
                    }

                    T t = (T)obiektGeometryczny;

                    if (func != null && !func.Invoke(t))
                    {
                        continue;
                    }

                    result.Add(t);
                }

                return result;
            }

            return result;
        }

        /// <summary>
        /// Pobiera pierwszy znaleziony obiekt geometryczny danego typu, który spełnia określone kryterium filtrowania.
        /// </summary>
        /// <typeparam name="T">Typ obiektu geometrycznego, który ma zostać pobrany.</typeparam>
        /// <param name="func">Opcjonalna funkcja filtrująca obiekty typu <typeparamref name="T"/>.</param>
        /// <returns>Obiekt typu <typeparamref name="T"/> spełniający kryteria lub wartość domyślna dla typu <typeparamref name="T"/>, jeśli nie znaleziono pasującego obiektu.</returns>
        public T? GetObiektGeometryczny<T>(Func<T, bool>? func = null) where T : IObiektGeometryczny
        {
            if (dictionary == null)
            {
                return default;
            }

            Type type = typeof(T);

            foreach (KeyValuePair<Type, List<IObiektGeometryczny>> keyValuePair in dictionary)
            {
                if (!type.IsAssignableFrom(keyValuePair.Key))
                {
                    continue;
                }

                foreach (IObiektGeometryczny obiektGeometryczny in keyValuePair.Value)
                {
                    if (obiektGeometryczny is not T)
                    {
                        continue;
                    }

                    T t = (T)obiektGeometryczny;

                    if (func != null && !func.Invoke(t))
                    {
                        continue;
                    }

                    return t;
                }
            }

            return default;
        }
    }
}
using DiGi.BDOT10k.Interfaces;
using DiGi.BDOT10k.Geometry.Classes;
using DiGi.BDOT10k.Geometry.Interfaces;
using DiGi.GML.Classes;
using DiGi.GML.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DiGi.BDOT10k.Geometry
{
    public static partial class Modify
    {
        /// <summary>
        /// Wczytuje obiekty geometryczne ze strumienia danych do słownika obiektów geometrycznych.
        /// </summary>
        /// <param name="slownikObiektowGeometrycznych">Słownik, do którego zostaną dodane wczytane obiekty.</param>
        /// <param name="stream">Strumień wejściowy zawierający dane w formacie GML.</param>
        /// <returns>Wartość <see cref="bool"/> wskazująca, czy udało się pomyślnie wczytać i dodać co najmniej jeden obiekt do słownika.</returns>
        public static bool Load(this SlownikObiektowGeometrycznych? slownikObiektowGeometrycznych, Stream? stream)
        {
            if (slownikObiektowGeometrycznych == null || stream == null)
            {
                return false;
            }

            FeatureCollection? featureCollection = GML.Convert.ToGML<FeatureCollection>(stream)?.FirstOrDefault();
            if (featureCollection == null)
            {
                return false;
            }

            return Load(slownikObiektowGeometrycznych, featureCollection);
        }

        /// <summary>
        /// Wczytuje obiekty geometryczne z pliku o podanej ścieżce do słownika obiektów geometrycznych.
        /// </summary>
        /// <param name="slownikObiektowGeometrycznych">Słownik, do którego zostaną dodane wczytane obiekty.</param>
        /// <param name="path">Ścieżka do pliku zawierającego dane w formacie GML.</param>
        /// <returns>Wartość <see cref="bool"/> wskazująca, czy udało się pomyślnie wczytać i dodać co najmniej jeden obiekt do słownika.</returns>
        public static bool Load(this SlownikObiektowGeometrycznych? slownikObiektowGeometrycznych, string? path)
        {
            if (slownikObiektowGeometrycznych == null || string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                return false;
            }

            FeatureCollection? featureCollection = GML.Convert.ToGML<FeatureCollection>(path)?.FirstOrDefault();
            if (featureCollection == null)
            {
                return false;
            }

            return Load(slownikObiektowGeometrycznych, featureCollection);
        }

        /// <summary>
        /// Wczytuje obiekty geometryczne z kolekcji cech do słownika obiektów geometrycznych.
        /// </summary>
        /// <param name="slownikObiektowGeometrycznych">Słownik, do którego zostaną dodane wczytane obiekty.</param>
        /// <param name="featureCollection">Kolekcja cech zawierająca elementy geometryczne.</param>
        /// <returns>Wartość <see cref="bool"/> wskazująca, czy udało się pomyślnie dodać co najmniej jeden obiekt do słownika.</returns>
        public static bool Load(this SlownikObiektowGeometrycznych slownikObiektowGeometrycznych, FeatureCollection featureCollection)
        {
            if (slownikObiektowGeometrycznych == null || featureCollection == null)
            {
                return false;
            }

            List<IFeatureMember> featureMembers = featureCollection.featureMember;
            if (featureMembers == null || featureMembers.Count == 0)
            {
                return false;
            }
            bool result = false;
            foreach (IFeatureMember featureMember in featureMembers)
            {
                if (featureMember is not IOT_ObiektGeometryczny)
                {
                    continue;
                }

                IObiektGeometryczny? obiektGeometryczny = Convert.ToDiGi((IOT_ObiektGeometryczny)featureMember);
                if (obiektGeometryczny == null)
                {
                    continue;
                }

                bool added = slownikObiektowGeometrycznych.Add(obiektGeometryczny);
                if (added)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
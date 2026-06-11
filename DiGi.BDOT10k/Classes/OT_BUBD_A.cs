using DiGi.BDOT10k.Enums;
using DiGi.BDOT10k.Interfaces;
using DiGi.GML.Classes;
using System.Collections.Generic;

namespace DiGi.BDOT10k.Classes
{
    /// <summary>
    /// Reprezentuje obiekt budynku w standardzie BDOT10k.
    /// </summary>
    public class OT_BUBD_A : OT_BudynkiBudowleIUrzadzenia, IOT_PowierzchniowyObiektGeometryczny
    {
        /// <summary>
        /// Kod klasyfikacji obiektów budowlanych (KST).
        /// </summary>
        public string? kodKst { get; set; } = null;

        /// <summary>
        /// Ogólna funkcja budynku.
        /// </summary>
        public OT_FunOgolnaBudynku? funkcjaOgolnaBudynku { get; set; } = null;

        /// <summary>
        /// Lista szczegółowych funkcji budynku.
        /// </summary>
        public List<OT_FunSzczegolowaBudynku>? funkcjaSzczegolowaBudynku { get; set; } = null;

        /// <summary>
        /// Przeważająca funkcja budynku.
        /// </summary>
        public OT_FunSzczegolowaBudynku przewazajacaFunkcjaBudynku { get; set; } = OT_FunSzczegolowaBudynku.budynek_jednorodzinny;

        /// <summary>
        /// Liczba kondygnacji w budynku.
        /// </summary>
        public ushort? liczbaKondygnacji { get; set; } = null;

        /// <summary>
        /// Nazwa budynku.
        /// </summary>
        public string? nazwa { get; set; } = null;

        /// <summary>
        /// Lista identyfikatorów z Ewidencji Gruntów i Budynków (EGiB).
        /// </summary>
        public List<string>? identyfikatorEGiB { get; set; } = null;

        /// <summary>
        /// Geometria powierzchniowa obiektu.
        /// </summary>
        public Surface geometria { get; set; } = new Polygon();

        /// <summary>
        /// Inicjalizuje nową instancję klasy <see cref="OT_BUBD_A"/>.
        /// </summary>
        public OT_BUBD_A()
        {
        }
    }
}
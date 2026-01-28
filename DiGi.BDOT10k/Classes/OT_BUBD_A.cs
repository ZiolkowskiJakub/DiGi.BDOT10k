using DiGi.BDOT10k.Enums;
using DiGi.BDOT10k.Interfaces;
using DiGi.GML.Classes;
using System.Collections.Generic;

namespace DiGi.BDOT10k.Classes
{
    public class OT_BUBD_A : OT_BudynkiBudowleIUrzadzenia, IOT_PowierzchniowyObiektGeometryczny
    {
        public string? kodKst { get; set; } = null;
        public OT_FunOgolnaBudynku? funkcjaOgolnaBudynku { get; set; } = null;
        public List<OT_FunSzczegolowaBudynku>? funkcjaSzczegolowaBudynku { get; set; } = null;
        public OT_FunSzczegolowaBudynku przewazajacaFunkcjaBudynku { get; set; } = OT_FunSzczegolowaBudynku.budynek_jednorodzinny;
        public ushort? liczbaKondygnacji { get; set; } = null;
        public string? nazwa { get; set; } = null;
        public List<string>? identyfikatorEGiB { get; set; } = null;
        public Surface geometria { get; set; } = new Polygon();

        public OT_BUBD_A()
        {
        }
    }
}
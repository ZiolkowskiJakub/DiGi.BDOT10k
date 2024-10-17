using DiGi.BDOT10k.Enums;
using DiGi.BDOT10k.Interfaces;
using DiGi.GML.Classes;
using System.Collections.Generic;

namespace DiGi.BDOT10k.Classes
{
    public class OT_BUBD_A : OT_BudynkiBudowleIUrzadzenia, IOT_PowierzchniowyObiektGeometryczny
    {
        public string? kodKst { get; set; }
        public OT_FunOgolnaBudynku? funkcjaOgolnaBudynku { get; set; }
        public List<OT_FunSzczegolowaBudynku>? funkcjaSzczegolowaBudynku { get; set; }
        public OT_FunSzczegolowaBudynku przewazajacaFunkcjaBudynku { get; set; }
        public ushort? liczbaKondygnacji { get; set; }
        public string? nazwa { get; set; }
        public List<string>? identyfikatorEGiB { get; set; }
        public Surface geometria { get; set; }

        public OT_BUBD_A()
        {

        }
    }
}

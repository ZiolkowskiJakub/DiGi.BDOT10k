using DiGi.BDOT10k.Enums;
using DiGi.GML.Classes;
using System.Collections.Generic;

namespace DiGi.BDOT10k.Classes
{
    public class OT_BUBD_A : OT_BudynkiBudowleIUrzadzenia
    {
        public string? kodKst { get; set; }
        public OT_FunOgolnaBudynku? funkcjaOgolnaBudynku { get; set; }
        public List<OT_FunSzczegolowaBudynkuType>? funkcjaSzczegolowaBudynku { get; set; }
        public OT_FunSzczegolowaBudynkuType przewazajacaFunkcjaBudynku { get; set; }
        public ushort? liczbaKondygnacji { get; set; }
        public string? nazwa { get; set; }
        public List<string>? identyfikatorEGiB { get; set; }
        public Surface geometria { get; set; }

        public OT_BUBD_A()
        {

        }
    }
}

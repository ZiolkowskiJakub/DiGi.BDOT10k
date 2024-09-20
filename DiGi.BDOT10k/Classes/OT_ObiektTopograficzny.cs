using DiGi.BDOT10k.Enums;
using System;

namespace DiGi.BDOT10k.Classes
{
    public abstract class OT_ObiektTopograficzny : GML.Classes.GML
    {
        public string lokalnyId { get; set; }
        public string przestrzenNazw { get; set; }
        public DateTime wersja { get; set; }
        public DateTime poczatekWersjiObiektu { get; set; }
        public DateTime? koniecWersjiObiektu { get; set; }
        public string oznaczenieZmiany { get; set; }
        public OT_ZrodloDanych zrodloDanychGeometrycznych { get; set; }
        public OT_KatIstnienia kategoriaIstnienia { get; set; }
        public string? uwagi { get; set; }
        public string? informacjaDodatkowa { get; set; }
        public string? kodKarto10k { get; set; }
        public string? kodKarto250k { get; set; }
        public string? skrotKartograficzny { get; set; }

        public OT_ObiektTopograficzny()
        {

        }
    }
}

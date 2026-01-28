using DiGi.BDOT10k.Enums;
using System;

namespace DiGi.BDOT10k.Classes
{
    public abstract class OT_ObiektTopograficzny : GML.Classes.GML
    {
        public string lokalnyId { get; set; } = string.Empty;
        public string przestrzenNazw { get; set; } = string.Empty;
        public DateTime wersja { get; set; } = DateTime.MinValue;
        public DateTime poczatekWersjiObiektu { get; set; } = DateTime.MinValue;
        public DateTime? koniecWersjiObiektu { get; set; } = null;
        public string oznaczenieZmiany { get; set; } = string.Empty;
        public OT_ZrodloDanych zrodloDanychGeometrycznych { get; set; } = OT_ZrodloDanych.inne;
        public OT_KatIstnienia kategoriaIstnienia { get; set; } = OT_KatIstnienia.eksploatowany;
        public string? uwagi { get; set; } = null;
        public string? informacjaDodatkowa { get; set; } = null;
        public string? kodKarto10k { get; set; } = null;
        public string? kodKarto250k { get; set; } = null;
        public string? skrotKartograficzny { get; set; } = null;

        public OT_ObiektTopograficzny()
        {
        }
    }
}
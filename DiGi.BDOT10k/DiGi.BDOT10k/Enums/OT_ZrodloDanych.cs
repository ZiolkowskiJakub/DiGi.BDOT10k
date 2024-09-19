using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DiGi.BDOT10k.Enums
{
    public enum OT_ZrodloDanych
    {
        [Description("EGiB")] EGiB,
        [Description("GESUT")] GESUT,
        [Description("PRG")] PRG,
        [Description("ortofotomapa")] ortofotomapa,
        [Description("BDOT500")] BDOT500,
        [Description("mapa zasadnicza")] mapa_zasadnicza,
        [Description("mapa topograficzna 10k")] mapa_topograficzna_10k,
        [Description("BDOT10k")] BDOT10k,
        [Description("Centralny Rejestr Form Ochrony Przyrody")] Centralny_Rejestr_Form_Ochrony_Przyrody,
        [Description("NMT")] NMT,
        [Description("pomiar terenowy")] pomiar_terenowy,
        [Description("inne")] inne,
    }
}

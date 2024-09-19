using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DiGi.BDOT10k.Enums
{
    public enum OT_FunOgolnaBudynku
    {
        [Description("budynki biurowe")] budynki_biurowe,
        [Description("budynki handlowo-usługowe")] budynki_handlowouslugowe,
        [Description("budynki mieszkalne")] budynki_mieszkalne,
        [Description("budynki oświaty, nauki i kultury oraz budynki sportowe")] budynki_oswiaty_nauki_i_kultury_oraz_budynki_sportowe,
        [Description("budynki produkcyjne, usługowe i gospodarcze dla rolnictwa")] budynki_produkcyjne_uslugowe_i_gospodarcze_dla_rolnictwa,
        [Description("budynki przemysłowe")] budynki_przemyslowe,
        [Description("budynki szpitali i inne budynki opieki zdrowotnej")] budynki_szpitali_i_inne_budynki_opieki_zdrowotnej,
        [Description("budynki transportu i łączności")] budynki_transportu_i_laczności,
        [Description("pozostałe budynki niemieszkalne")] pozostale_budynki_niemieszkalne,
        [Description("zbiorniki, silosy i budynki magazynowe")] zbiorniki_silosy_i_budynki_magazynowe,
    }
}

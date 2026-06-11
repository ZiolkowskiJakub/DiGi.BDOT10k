using System.ComponentModel;

namespace DiGi.BDOT10k.Enums
{
    /// <summary>
    /// Reprezentuje ogólną funkcję budynku w systemie BDOT10k.
    /// </summary>
    public enum OT_FunOgolnaBudynku
    {
        /// <summary>
        /// Budynki biurowe.
        /// </summary>
        [Description("budynki biurowe")] budynki_biurowe,

        /// <summary>
        /// Budynki handlowo-usługowe.
        /// </summary>
        [Description("budynki handlowo-usługowe")] budynki_handlowouslugowe,

        /// <summary>
        /// Budynki mieszkalne.
        /// </summary>
        [Description("budynki mieszkalne")] budynki_mieszkalne,

        /// <summary>
        /// Budynki oświaty, nauki i kultury oraz budynki sportowe.
        /// </summary>
        [Description("budynki oświaty, nauki i kultury oraz budynki sportowe")] budynki_oswiaty_nauki_i_kultury_oraz_budynki_sportowe,

        /// <summary>
        /// Budynki produkcyjne, usługowe i gospodarcze dla rolnictwa.
        /// </summary>
        [Description("budynki produkcyjne, usługowe i gospodarcze dla rolnictwa")] budynki_produkcyjne_uslugowe_i_gospodarcze_dla_rolnictwa,

        /// <summary>
        /// Budynki przemysłowe.
        /// </summary>
        [Description("budynki przemysłowe")] budynki_przemyslowe,

        /// <summary>
        /// Budynki szpitali i inne budynki opieki zdrowotnej.
        /// </summary>
        [Description("budynki szpitali i inne budynki opieki zdrowotnej")] budynki_szpitali_i_inne_budynki_opieki_zdrowotnej,

        /// <summary>
        /// Budynki transportu i łączności.
        /// </summary>
        [Description("budynki transportu i łączności")] budynki_transportu_i_laczności,

        /// <summary>
        /// Pozostałe budynki niemieszkalne.
        /// </summary>
        [Description("pozostałe budynki niemieszkalne")] pozostale_budynki_niemieszkalne,

        /// <summary>
        /// Zbiorniki, silosy i budynki magazynowe.
        /// </summary>
        [Description("zbiorniki, silosy i budynki magazynowe")] zbiorniki_silosy_i_budynki_magazynowe,
    }
}
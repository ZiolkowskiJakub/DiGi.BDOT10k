using System.ComponentModel;

namespace DiGi.BDOT10k.Enums
{
    /// <summary>
    /// Wyznacza źródło pochodzenia danych dla obiektów w bazie BDOT10k.
    /// </summary>
    public enum OT_ZrodloDanych
    {
        /// <summary>
        /// Ewidencja Gruntów i Budynków (EGiB).
        /// </summary>
        [Description("EGiB")] EGiB,

        /// <summary>
        /// Główny Ewidencjonowany Spis Urządzeń Technicznych (GESUT).
        /// </summary>
        [Description("GESUT")] GESUT,

        /// <summary>
        /// Plan Zagospodarowania Przestrzennego (PRG).
        /// </summary>
        [Description("PRG")] PRG,

        /// <summary>
        /// Ortofotomapa.
        /// </summary>
        [Description("ortofotomapa")] ortofotomapa,

        /// <summary>
        /// Baza Danych Obiektów Topograficznych w skali 1:500 (BDOT500).
        /// </summary>
        [Description("BDOT500")] BDOT500,

        /// <summary>
        /// Mapa zasadnicza.
        /// </summary>
        [Description("mapa zasadnicza")] mapa_zasadnicza,

        /// <summary>
        /// Mapa topograficzna w skali 1:10 000.
        /// </summary>
        [Description("mapa topograficzna 10k")] mapa_topograficzna_10k,

        /// <summary>
        /// Baza Danych Obiektów Topograficznych w skali 1:10 000 (BDOT10k).
        /// </summary>
        [Description("BDOT10k")] BDOT10k,

        /// <summary>
        /// Centralny Rejestr Form Ochrony Przyrody.
        /// </summary>
        [Description("Centralny Rejestr Form Ochrony Przyrody")] Centralny_Rejestr_Form_Ochrony_Przyrody,

        /// <summary>
        /// Numeryczny Model Terenu (NMT).
        /// </summary>
        [Description("NMT")] NMT,

        /// <summary>
        /// Pomiar terenowy.
        /// </summary>
        [Description("pomiar terenowy")] pomiar_terenowy,

        /// <summary>
        /// Inne źródło danych.
        /// </summary>
        [Description("inne")] inne,
    }
}
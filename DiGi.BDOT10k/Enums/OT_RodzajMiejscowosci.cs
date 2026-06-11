using System.ComponentModel;

namespace DiGi.BDOT10k.Enums
{
    /// <summary>
    /// Reprezentuje rodzaje miejscowości zgodnie ze specyfikacją BDOT10k.
    /// </summary>
    public enum OT_RodzajMiejscowosci
    {
        /// <summary>
        /// Miasto.
        /// </summary>
        [Description("miasto")] miasto,

        /// <summary>
        /// Część miasta.
        /// </summary>
        [Description("część miasta")] czesc_miasta,

        /// <summary>
        /// Wieś.
        /// </summary>
        [Description("wieś")] wies,

        /// <summary>
        /// Część wsi.
        /// </summary>
        [Description("część wsi")] czesc_wsi,

        /// <summary>
        /// Kolonia.
        /// </summary>
        [Description("kolonia")] kolonia,

        /// <summary>
        /// Część kolonii.
        /// </summary>
        [Description("część kolonii")] czesc_kolonii,

        /// <summary>
        /// Osada.
        /// </summary>
        [Description("osada")] osada,

        /// <summary>
        /// Część osady.
        /// </summary>
        [Description("część osady")] czesc_osady,

        /// <summary>
        /// Osiedle.
        /// </summary>
        [Description("osiedle")] osiedle,

        /// <summary>
        /// Przysiółek.
        /// </summary>
        [Description("przysiółek")] przysiolek,

        /// <summary>
        /// Osada leśna.
        /// </summary>
        [Description("osada leśna")] osada_lesna,

        /// <summary>
        /// Inny obiekt.
        /// </summary>
        [Description("inny obiekt")] inny_obiekt,
    }
}
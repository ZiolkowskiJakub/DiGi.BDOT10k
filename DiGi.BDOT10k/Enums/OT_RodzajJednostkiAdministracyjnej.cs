using System.ComponentModel;

namespace DiGi.BDOT10k.Enums
{
    /// <summary>
    /// Reprezentuje rodzaj jednostki administracyjnej w systemie BDOT10k.
    /// </summary>
    public enum OT_RodzajJednostkiAdministracyjnej
    {
        /// <summary>
        /// Państwo.
        /// </summary>
        [Description("państwo")] panstwo,

        /// <summary>
        /// Województwo.
        /// </summary>
        [Description("województwo")] wojewodztwo,

        /// <summary>
        /// Powiat.
        /// </summary>
        [Description("powiat")] powiat,

        /// <summary>
        /// Gmina.
        /// </summary>
        [Description("gmina")] gmina,

        /// <summary>
        /// Miasto w gminie miejsko-wiejskiej.
        /// </summary>
        [Description("miasto w gminie miejsko-wiejskiej")] miasto_w_gminie_miejsko_wiejskiej,

        /// <summary>
        /// Dzielnica lub delegatura.
        /// </summary>
        [Description("dzielnica lub delegatura")] dzielnica_lub_delegatura,
    }
}
using System.ComponentModel;

namespace DiGi.BDOT10k.Enums
{
    /// <summary>
    /// Reprezentuje kategorię istnienia obiektu w standardzie BDOT10k.
    /// </summary>
    public enum OT_KatIstnienia
    {
        /// <summary>
        /// Obiekt jest eksploatowany.
        /// </summary>
        [Description("eksploatowany")] 
        eksploatowany,

        /// <summary>
        /// Obiekt jest nieczynny.
        /// </summary>
        [Description("nieczynny")] 
        nieczynny,

        /// <summary>
        /// Obiekt znajduje się w budowie.
        /// </summary>
        [Description("w budowie")] 
        w_budowie,

        /// <summary>
        /// Obiekt został zniszczony.
        /// </summary>
        [Description("zniszczony")] 
        zniszczony,
    }
}
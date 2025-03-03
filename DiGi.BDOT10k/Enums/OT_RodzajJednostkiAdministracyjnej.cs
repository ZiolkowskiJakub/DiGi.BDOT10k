using System.ComponentModel;

namespace DiGi.BDOT10k.Enums
{
    public enum OT_RodzajJednostkiAdministracyjnej
    {
        [Description("państwo")] panstwo,
        [Description("województwo")] wojewodztwo,
        [Description("powiat")] powiat,
        [Description("gmina")] gmina,
        [Description("miasto w gminie miejsko-wiejskiej")] miasto_w_gminie_miejsko_wiejskiej,
        [Description("dzielnica lub delegatura")] dzielnica_lub_delegatura,
    }
}

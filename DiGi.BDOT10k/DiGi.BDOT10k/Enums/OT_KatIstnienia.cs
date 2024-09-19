using System.ComponentModel;

namespace DiGi.BDOT10k.Enums
{
    public enum OT_KatIstnienia
    {
        [Description("eksploatowany")] eksploatowany,
        [Description("nieczynny")] nieczynny,
        [Description("w budowie")] w_budowie,
        [Description("zniszczony")] zniszczony,
    }
}

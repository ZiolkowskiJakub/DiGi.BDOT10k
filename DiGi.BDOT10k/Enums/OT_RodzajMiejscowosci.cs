using System.ComponentModel;

namespace DiGi.BDOT10k.Enums
{
    public enum OT_RodzajMiejscowosci
    {
        [Description("miasto")] miasto,
        [Description("część miasta")] czesc_miasta,
        [Description("wieś")] wies,
        [Description("część wsi")] czesc_wsi,
        [Description("kolonia")] kolonia,
        [Description("część kolonii")] czesc_kolonii,
        [Description("osada")] osada,
        [Description("część osady")] czesc_osady,
        [Description("osiedle")] osiedle,
        [Description("przysiółek")] przysiolek,
        [Description("osada leśna")] osada_lesna,
        [Description("inny obiekt")] inny_obiekt,
    }
}

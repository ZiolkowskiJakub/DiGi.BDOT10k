using DiGi.BDOT10k.Classes;
using DiGi.GML;
using DiGi.GML.Classes;
using DiGi.GML.Interfaces;
using System.Xml;

namespace DiGi.BDOT10k.Test
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Load_Click(object sender, EventArgs e)
        {
            string path = null;

            path = @"C:\Users\jakub\Downloads\Geoportal\PL.PZGiK.337.0201__OT_BUBD_A.xml";
            path = @"C:\Users\jakub\Downloads\Geoportal\PL.PZGiK.337.0201__OT_ADMS_A.xml";

            OT_ADMS_A oT_ADMS_A = new OT_ADMS_A();

            FeatureCollection featureCollection = GML.Convert.ToGML<FeatureCollection>(path)?.FirstOrDefault();

            //using (OpenFileDialog openFileDialog = new OpenFileDialog())
            //{
            //    openFileDialog.Filter = "zip files (*.zip)|*.zip|All files (*.*)|*.*";

            //    if (openFileDialog.ShowDialog(this) != DialogResult.OK)
            //    {
            //        return;
            //    }

            //    path = openFileDialog.FileName;
            //}

            //using (ZipArchive zipArchive = ZipFile.OpenRead(path))
            //{
            //    foreach (ZipArchiveEntry zipArchiveEntry in zipArchive.Entries)
            //    {
            //        Stream stream = zipArchiveEntry.Open();
            //        using (ZipArchive zipArchive_ZipArchieve = new ZipArchive(stream))
            //        {
            //            foreach (ZipArchiveEntry zipArchiveEntry_Zip in zipArchive_ZipArchieve.Entries)
            //            {
            //                string name = zipArchiveEntry_Zip.Name;
            //                string fullName = zipArchiveEntry_Zip.FullName;
            //            }
            //        }
            //    }
            //}
        }

        private void Button_Clone_Click(object sender, EventArgs e)
        {
            string path = null;

            //path = @"C:\Users\jakub\Downloads\PL.PZGiK.337.0201__OT_BUBD_A.xml";
            path = @"C:\Users\jakub\Downloads\Geoportal\PL.PZGiK.337.0201__OT_ADMS_A.xml";

            OT_ADMS_A oT_ADMS_A = new OT_ADMS_A();

            FeatureCollection featureCollection = GML.Convert.ToGML<FeatureCollection>(path)?.FirstOrDefault();
            List<IFeatureMember> featureMembers = featureCollection.featureMember;
            if(featureMembers == null)
            {
                return;
            }

            foreach (OT_ADMS_A OT_ADMS_A in featureCollection.featureMember)
            {
                OT_ADMS_A OT_ADMS_A_Colne = OT_ADMS_A.Clone();
            }
        }
    }
}

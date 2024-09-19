using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                path = openFileDialog.FileName;
            }
        }
    }
}

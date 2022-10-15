using System.IO;

namespace Nim
{
    public partial class MainForm : Form
    {
        private string defaultPath;
        public MainForm()
        {
            InitializeComponent();
            defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);


            txtPackageName.Text = "NimPackage";
            txtPublisher.Text = "Nim";
            txtInstallLocation.Text = defaultPath;
            setInstallLocation(txtPackageName.Text, txtPublisher.Text, txtInstallLocation.Text);

        }


        private void btnZipLocation_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtZipLocation.Text = ofd.FileName;
                txtPackageName.Text = Path.GetFileNameWithoutExtension(txtZipLocation.Text);

                setInstallLocation(txtPackageName.Text, txtPublisher.Text, txtInstallLocation.Text);


            }
        }

        private void txtDetailsChanged(object sender, EventArgs e)
        {
            setInstallLocation(txtPackageName.Text, txtPublisher.Text, txtInstallLocation.Text);

        }

        private void setInstallLocation(string packageName, string publisherName, string installLocation)
        {
            if (publisherName == "")
            {

                if (packageName == "")
                {
                    txtFinalized.Text = installLocation;
                    return;
                }

                txtFinalized.Text = installLocation + @"\" + packageName;
            }
            else if (packageName == "")
            {
                txtFinalized.Text = installLocation + @"\" + publisherName;
                return;
            }
            txtFinalized.Text = installLocation + @"\" + publisherName + @"\" + packageName;


        }

        private void btnInstallLocation_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtInstallLocation.Text = fbd.SelectedPath;
                setInstallLocation(txtPackageName.Text, txtPublisher.Text, txtInstallLocation.Text);

            }
        }
    }


}
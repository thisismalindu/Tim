using IWshRuntimeLibrary;
using System.IO;

namespace Tim
{
    public partial class MainForm : Form
    {
        private string defaultPath; //Default Install Location (eg:Program Files)
        private string defaultIcon; //Default Icon of the Shortcut
        private string exePath; //Shortcut EXE Path
        private string iconPath; //
        public MainForm()
        {
            InitializeComponent();
            defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);


            txtPackageName.Text = "TimPackage";
            txtPublisher.Text = "Tim";
            txtInstallLocation.Text = defaultPath;
            setInstallLocation(txtPackageName.Text, txtPublisher.Text, txtInstallLocation.Text);



            exePath = @"D:\Installers\Tools\OOSU10.exe";





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



        private void btnInstallLocation_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtInstallLocation.Text = fbd.SelectedPath;
                setInstallLocation(txtPackageName.Text, txtPublisher.Text, txtInstallLocation.Text);

            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {

        }




        //EXTRA FUNCTIONS

        //Set the Finalized Installation Location to the txtFinalized TexBox
        private void setInstallLocation(string packageName, string publisherName, string installLocation)
        {
            if (publisherName == "")
            {

                if (packageName == "")
                {
                    txtFinalized.Text = installLocation;
                    return;
                }

                txtFinalized.Text = System.IO.Path.Combine(installLocation, packageName);

            }
            else if (packageName == "")
            {
                txtFinalized.Text = System.IO.Path.Combine(installLocation, publisherName);
                return;
            }
            txtFinalized.Text = System.IO.Path.Combine(installLocation, publisherName, packageName);


        }

        //Make Shortcuts based on the checkboxes: Desktop, Startmenu and Startup
        private void makeShortcuts()
        {
            //if (chkDesktop.Checked)
            //{
            //    Utilities.CreateShortcut(txtPackageName.Text, Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Open " + txtPackageName.Text, exePath, exePath);
            //}
            //if (chkStartMenu.Checked)
            //{
            //    Utilities.CreateShortcut(txtPackageName.Text, Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), "Open " + txtPackageName.Text, exePath, iconPath);
            //}
            //if (chkStartup.Checked)
            //{
            //    Utilities.CreateShortcut(txtPackageName.Text, Environment.GetFolderPath(Environment.SpecialFolder.Startup), "Open " + txtPackageName.Text, exePath, iconPath);
            //}

        }

        

        


    }


}
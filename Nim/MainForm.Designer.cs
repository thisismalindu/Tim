namespace Nim
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBasicDetails = new System.Windows.Forms.GroupBox();
            this.btnInstallLocation = new System.Windows.Forms.Button();
            this.txtInstallLocation = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.lblInstallLocaiton = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.grpShortcuts = new System.Windows.Forms.GroupBox();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.chkStartMenu = new System.Windows.Forms.CheckBox();
            this.chkDesktop = new System.Windows.Forms.CheckBox();
            this.chkCreateUninstaller = new System.Windows.Forms.CheckBox();
            this.btnInstall = new System.Windows.Forms.Button();
            this.pnlDrop = new System.Windows.Forms.Panel();
            this.btnZipLocation = new System.Windows.Forms.Button();
            this.txtZipLocation = new System.Windows.Forms.TextBox();
            this.lblZipLocation = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.grpBasicDetails.SuspendLayout();
            this.grpShortcuts.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBasicDetails
            // 
            this.grpBasicDetails.Controls.Add(this.btnInstallLocation);
            this.grpBasicDetails.Controls.Add(this.txtInstallLocation);
            this.grpBasicDetails.Controls.Add(this.txtPublisher);
            this.grpBasicDetails.Controls.Add(this.txtPackageName);
            this.grpBasicDetails.Controls.Add(this.lblInstallLocaiton);
            this.grpBasicDetails.Controls.Add(this.lblPublisher);
            this.grpBasicDetails.Controls.Add(this.lblPackageName);
            this.grpBasicDetails.ForeColor = System.Drawing.Color.Black;
            this.grpBasicDetails.Location = new System.Drawing.Point(12, 243);
            this.grpBasicDetails.Name = "grpBasicDetails";
            this.grpBasicDetails.Size = new System.Drawing.Size(340, 134);
            this.grpBasicDetails.TabIndex = 1;
            this.grpBasicDetails.TabStop = false;
            this.grpBasicDetails.Text = "Basic Details";
            // 
            // btnInstallLocation
            // 
            this.btnInstallLocation.Location = new System.Drawing.Point(226, 96);
            this.btnInstallLocation.Name = "btnInstallLocation";
            this.btnInstallLocation.Size = new System.Drawing.Size(28, 23);
            this.btnInstallLocation.TabIndex = 8;
            this.btnInstallLocation.Text = "...";
            this.btnInstallLocation.UseVisualStyleBackColor = true;
            // 
            // txtInstallLocation
            // 
            this.txtInstallLocation.Location = new System.Drawing.Point(113, 96);
            this.txtInstallLocation.Name = "txtInstallLocation";
            this.txtInstallLocation.Size = new System.Drawing.Size(107, 23);
            this.txtInstallLocation.TabIndex = 9;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(113, 60);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(107, 23);
            this.txtPublisher.TabIndex = 8;
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(113, 24);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(107, 23);
            this.txtPackageName.TabIndex = 7;
            // 
            // lblInstallLocaiton
            // 
            this.lblInstallLocaiton.AutoSize = true;
            this.lblInstallLocaiton.ForeColor = System.Drawing.Color.Black;
            this.lblInstallLocaiton.Location = new System.Drawing.Point(14, 100);
            this.lblInstallLocaiton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblInstallLocaiton.Name = "lblInstallLocaiton";
            this.lblInstallLocaiton.Size = new System.Drawing.Size(87, 15);
            this.lblInstallLocaiton.TabIndex = 6;
            this.lblInstallLocaiton.Text = "Install Location";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.ForeColor = System.Drawing.Color.Black;
            this.lblPublisher.Location = new System.Drawing.Point(14, 64);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(56, 15);
            this.lblPublisher.TabIndex = 5;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.ForeColor = System.Drawing.Color.Black;
            this.lblPackageName.Location = new System.Drawing.Point(14, 28);
            this.lblPackageName.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(86, 15);
            this.lblPackageName.TabIndex = 4;
            this.lblPackageName.Text = "Package Name";
            // 
            // grpShortcuts
            // 
            this.grpShortcuts.Controls.Add(this.chkStartup);
            this.grpShortcuts.Controls.Add(this.chkStartMenu);
            this.grpShortcuts.Controls.Add(this.chkDesktop);
            this.grpShortcuts.ForeColor = System.Drawing.Color.Black;
            this.grpShortcuts.Location = new System.Drawing.Point(358, 243);
            this.grpShortcuts.Name = "grpShortcuts";
            this.grpShortcuts.Size = new System.Drawing.Size(116, 134);
            this.grpShortcuts.TabIndex = 7;
            this.grpShortcuts.TabStop = false;
            this.grpShortcuts.Text = "Shortcuts";
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.ForeColor = System.Drawing.Color.Black;
            this.chkStartup.Location = new System.Drawing.Point(13, 77);
            this.chkStartup.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(64, 19);
            this.chkStartup.TabIndex = 9;
            this.chkStartup.Text = "Startup";
            this.chkStartup.UseVisualStyleBackColor = true;
            // 
            // chkStartMenu
            // 
            this.chkStartMenu.AutoSize = true;
            this.chkStartMenu.ForeColor = System.Drawing.Color.Black;
            this.chkStartMenu.Location = new System.Drawing.Point(13, 52);
            this.chkStartMenu.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.chkStartMenu.Name = "chkStartMenu";
            this.chkStartMenu.Size = new System.Drawing.Size(84, 19);
            this.chkStartMenu.TabIndex = 8;
            this.chkStartMenu.Text = "Start Menu";
            this.chkStartMenu.UseVisualStyleBackColor = true;
            // 
            // chkDesktop
            // 
            this.chkDesktop.AutoSize = true;
            this.chkDesktop.ForeColor = System.Drawing.Color.Black;
            this.chkDesktop.Location = new System.Drawing.Point(13, 28);
            this.chkDesktop.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.chkDesktop.Name = "chkDesktop";
            this.chkDesktop.Size = new System.Drawing.Size(69, 19);
            this.chkDesktop.TabIndex = 7;
            this.chkDesktop.Text = "Desktop";
            this.chkDesktop.UseVisualStyleBackColor = true;
            // 
            // chkCreateUninstaller
            // 
            this.chkCreateUninstaller.AutoSize = true;
            this.chkCreateUninstaller.Checked = true;
            this.chkCreateUninstaller.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateUninstaller.ForeColor = System.Drawing.Color.Black;
            this.chkCreateUninstaller.Location = new System.Drawing.Point(184, 388);
            this.chkCreateUninstaller.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.chkCreateUninstaller.Name = "chkCreateUninstaller";
            this.chkCreateUninstaller.Size = new System.Drawing.Size(119, 19);
            this.chkCreateUninstaller.TabIndex = 10;
            this.chkCreateUninstaller.Text = "Create Uninstaller";
            this.chkCreateUninstaller.UseVisualStyleBackColor = true;
            // 
            // btnInstall
            // 
            this.btnInstall.AutoSize = true;
            this.btnInstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInstall.Location = new System.Drawing.Point(183, 416);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(120, 32);
            this.btnInstall.TabIndex = 10;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            // 
            // pnlDrop
            // 
            this.pnlDrop.BackgroundImage = global::Nim.Properties.Resources.drag_n_drop_here;
            this.pnlDrop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrop.Location = new System.Drawing.Point(12, 12);
            this.pnlDrop.Name = "pnlDrop";
            this.pnlDrop.Size = new System.Drawing.Size(462, 188);
            this.pnlDrop.TabIndex = 14;
            // 
            // btnZipLocation
            // 
            this.btnZipLocation.AutoSize = true;
            this.btnZipLocation.Location = new System.Drawing.Point(406, 208);
            this.btnZipLocation.Name = "btnZipLocation";
            this.btnZipLocation.Size = new System.Drawing.Size(68, 25);
            this.btnZipLocation.TabIndex = 11;
            this.btnZipLocation.Text = "Select";
            this.btnZipLocation.UseVisualStyleBackColor = true;
            this.btnZipLocation.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtZipLocation
            // 
            this.txtZipLocation.Location = new System.Drawing.Point(98, 209);
            this.txtZipLocation.Name = "txtZipLocation";
            this.txtZipLocation.Size = new System.Drawing.Size(302, 23);
            this.txtZipLocation.TabIndex = 12;
            // 
            // lblZipLocation
            // 
            this.lblZipLocation.AutoSize = true;
            this.lblZipLocation.ForeColor = System.Drawing.Color.Black;
            this.lblZipLocation.Location = new System.Drawing.Point(12, 213);
            this.lblZipLocation.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblZipLocation.Name = "lblZipLocation";
            this.lblZipLocation.Size = new System.Drawing.Size(73, 15);
            this.lblZipLocation.TabIndex = 10;
            this.lblZipLocation.Text = "Zip Location";
            // 
            // fbd
            // 
            this.fbd.InitialDirectory = "Program Files";
            this.fbd.RootFolder = System.Environment.SpecialFolder.ProgramFiles;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(486, 457);
            this.Controls.Add(this.btnZipLocation);
            this.Controls.Add(this.pnlDrop);
            this.Controls.Add(this.txtZipLocation);
            this.Controls.Add(this.lblZipLocation);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.chkCreateUninstaller);
            this.Controls.Add(this.grpShortcuts);
            this.Controls.Add(this.grpBasicDetails);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(502, 496);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Install with Nim";
            this.grpBasicDetails.ResumeLayout(false);
            this.grpBasicDetails.PerformLayout();
            this.grpShortcuts.ResumeLayout(false);
            this.grpShortcuts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox grpBasicDetails;
        private Label lblInstallLocaiton;
        private Label lblPublisher;
        private Label lblPackageName;
        private GroupBox grpShortcuts;
        private CheckBox chkStartup;
        private CheckBox chkStartMenu;
        private CheckBox chkDesktop;
        private Button btnInstallLocation;
        private TextBox txtInstallLocation;
        private TextBox txtPublisher;
        private TextBox txtPackageName;
        private CheckBox chkCreateUninstaller;
        private Button btnInstall;
        private Panel pnlDrop;
        private Button btnZipLocation;
        private TextBox txtZipLocation;
        private Label lblZipLocation;
        private OpenFileDialog ofd;
        private FolderBrowserDialog fbd;
    }
}
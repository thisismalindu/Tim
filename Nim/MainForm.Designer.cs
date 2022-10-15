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
            this.txtFinalized = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.grpBasicDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBasicDetails.Controls.Add(this.txtFinalized);
            this.grpBasicDetails.Controls.Add(this.label1);
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
            this.grpBasicDetails.Size = new System.Drawing.Size(462, 161);
            this.grpBasicDetails.TabIndex = 1;
            this.grpBasicDetails.TabStop = false;
            this.grpBasicDetails.Text = "Basic Details";
            // 
            // txtFinalized
            // 
            this.txtFinalized.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinalized.Enabled = false;
            this.txtFinalized.Location = new System.Drawing.Point(113, 123);
            this.txtFinalized.Name = "txtFinalized";
            this.txtFinalized.Size = new System.Drawing.Size(340, 23);
            this.txtFinalized.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Finalized";
            // 
            // btnInstallLocation
            // 
            this.btnInstallLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstallLocation.AutoSize = true;
            this.btnInstallLocation.Location = new System.Drawing.Point(385, 89);
            this.btnInstallLocation.Name = "btnInstallLocation";
            this.btnInstallLocation.Size = new System.Drawing.Size(68, 25);
            this.btnInstallLocation.TabIndex = 5;
            this.btnInstallLocation.Text = "Browse";
            this.btnInstallLocation.UseVisualStyleBackColor = true;
            this.btnInstallLocation.Click += new System.EventHandler(this.btnInstallLocation_Click);
            // 
            // txtInstallLocation
            // 
            this.txtInstallLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstallLocation.Enabled = false;
            this.txtInstallLocation.Location = new System.Drawing.Point(113, 90);
            this.txtInstallLocation.Name = "txtInstallLocation";
            this.txtInstallLocation.Size = new System.Drawing.Size(266, 23);
            this.txtInstallLocation.TabIndex = 4;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublisher.Location = new System.Drawing.Point(113, 57);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(340, 23);
            this.txtPublisher.TabIndex = 3;
            this.txtPublisher.TextChanged += new System.EventHandler(this.txtDetailsChanged);
            // 
            // txtPackageName
            // 
            this.txtPackageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPackageName.Location = new System.Drawing.Point(113, 24);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(340, 23);
            this.txtPackageName.TabIndex = 2;
            this.txtPackageName.TextChanged += new System.EventHandler(this.txtDetailsChanged);
            // 
            // lblInstallLocaiton
            // 
            this.lblInstallLocaiton.AutoSize = true;
            this.lblInstallLocaiton.ForeColor = System.Drawing.Color.Black;
            this.lblInstallLocaiton.Location = new System.Drawing.Point(14, 94);
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
            this.lblPublisher.Location = new System.Drawing.Point(14, 61);
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
            this.grpShortcuts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpShortcuts.Controls.Add(this.chkStartup);
            this.grpShortcuts.Controls.Add(this.chkStartMenu);
            this.grpShortcuts.Controls.Add(this.chkDesktop);
            this.grpShortcuts.ForeColor = System.Drawing.Color.Black;
            this.grpShortcuts.Location = new System.Drawing.Point(12, 409);
            this.grpShortcuts.Name = "grpShortcuts";
            this.grpShortcuts.Size = new System.Drawing.Size(462, 56);
            this.grpShortcuts.TabIndex = 7;
            this.grpShortcuts.TabStop = false;
            this.grpShortcuts.Text = "Shortcuts";
            // 
            // chkStartup
            // 
            this.chkStartup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStartup.AutoSize = true;
            this.chkStartup.ForeColor = System.Drawing.Color.Black;
            this.chkStartup.Location = new System.Drawing.Point(384, 24);
            this.chkStartup.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(64, 19);
            this.chkStartup.TabIndex = 8;
            this.chkStartup.Text = "Startup";
            this.chkStartup.UseVisualStyleBackColor = true;
            // 
            // chkStartMenu
            // 
            this.chkStartMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkStartMenu.AutoSize = true;
            this.chkStartMenu.Checked = true;
            this.chkStartMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStartMenu.ForeColor = System.Drawing.Color.Black;
            this.chkStartMenu.Location = new System.Drawing.Point(191, 24);
            this.chkStartMenu.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.chkStartMenu.Name = "chkStartMenu";
            this.chkStartMenu.Size = new System.Drawing.Size(84, 19);
            this.chkStartMenu.TabIndex = 7;
            this.chkStartMenu.Text = "Start Menu";
            this.chkStartMenu.UseVisualStyleBackColor = true;
            // 
            // chkDesktop
            // 
            this.chkDesktop.AutoSize = true;
            this.chkDesktop.Checked = true;
            this.chkDesktop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDesktop.ForeColor = System.Drawing.Color.Black;
            this.chkDesktop.Location = new System.Drawing.Point(13, 24);
            this.chkDesktop.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.chkDesktop.Name = "chkDesktop";
            this.chkDesktop.Size = new System.Drawing.Size(69, 19);
            this.chkDesktop.TabIndex = 6;
            this.chkDesktop.Text = "Desktop";
            this.chkDesktop.UseVisualStyleBackColor = true;
            // 
            // chkCreateUninstaller
            // 
            this.chkCreateUninstaller.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkCreateUninstaller.AutoSize = true;
            this.chkCreateUninstaller.Checked = true;
            this.chkCreateUninstaller.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateUninstaller.ForeColor = System.Drawing.Color.Black;
            this.chkCreateUninstaller.Location = new System.Drawing.Point(184, 474);
            this.chkCreateUninstaller.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.chkCreateUninstaller.Name = "chkCreateUninstaller";
            this.chkCreateUninstaller.Size = new System.Drawing.Size(119, 19);
            this.chkCreateUninstaller.TabIndex = 9;
            this.chkCreateUninstaller.Text = "Create Uninstaller";
            this.chkCreateUninstaller.UseVisualStyleBackColor = true;
            // 
            // btnInstall
            // 
            this.btnInstall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInstall.Location = new System.Drawing.Point(183, 494);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(120, 35);
            this.btnInstall.TabIndex = 10;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            // 
            // pnlDrop
            // 
            this.pnlDrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnZipLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZipLocation.AutoSize = true;
            this.btnZipLocation.Location = new System.Drawing.Point(406, 208);
            this.btnZipLocation.Name = "btnZipLocation";
            this.btnZipLocation.Size = new System.Drawing.Size(68, 25);
            this.btnZipLocation.TabIndex = 0;
            this.btnZipLocation.Text = "Select";
            this.btnZipLocation.UseVisualStyleBackColor = true;
            this.btnZipLocation.Click += new System.EventHandler(this.btnZipLocation_Click);
            // 
            // txtZipLocation
            // 
            this.txtZipLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZipLocation.Enabled = false;
            this.txtZipLocation.Location = new System.Drawing.Point(98, 209);
            this.txtZipLocation.Name = "txtZipLocation";
            this.txtZipLocation.Size = new System.Drawing.Size(302, 23);
            this.txtZipLocation.TabIndex = 1;
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
            // ofd
            // 
            this.ofd.Filter = "Zip files (*.zip)|*.zip";
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
            this.ClientSize = new System.Drawing.Size(486, 537);
            this.Controls.Add(this.btnZipLocation);
            this.Controls.Add(this.pnlDrop);
            this.Controls.Add(this.txtZipLocation);
            this.Controls.Add(this.lblZipLocation);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.chkCreateUninstaller);
            this.Controls.Add(this.grpShortcuts);
            this.Controls.Add(this.grpBasicDetails);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(502, 576);
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
        private TextBox txtFinalized;
        private Label label1;
    }
}
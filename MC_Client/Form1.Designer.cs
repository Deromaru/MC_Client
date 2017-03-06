﻿namespace MC_Client
{
    partial class Form_ER
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ER));
            this.comboBox_Versions = new System.Windows.Forms.ComboBox();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.button_Path = new System.Windows.Forms.Button();
            this.button_Install = new System.Windows.Forms.Button();
            this.checkBox_Dev = new System.Windows.Forms.CheckBox();
            this.checkBox_Log = new System.Windows.Forms.CheckBox();
            this.checkBox_Biome = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_Fresh = new System.Windows.Forms.CheckBox();
            this.checkBox_Timer = new System.Windows.Forms.CheckBox();
            this.textBox1_time = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_Modpack = new System.Windows.Forms.Button();
            this.ERnotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Settings_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.setings_button = new System.Windows.Forms.PictureBox();
            this.comboBox_Pack = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.temp_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.to_tray = new System.Windows.Forms.PictureBox();
            this.pictureBox_ERlogo = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_version = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.label_InstalledV = new System.Windows.Forms.Label();
            this.pictureBox_PackLogo = new System.Windows.Forms.PictureBox();
            this.Settings_panel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setings_button)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.to_tray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ERlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PackLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Versions
            // 
            this.comboBox_Versions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Versions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Versions.Location = new System.Drawing.Point(93, 342);
            this.comboBox_Versions.Name = "comboBox_Versions";
            this.comboBox_Versions.Size = new System.Drawing.Size(142, 21);
            this.comboBox_Versions.TabIndex = 2;
            this.comboBox_Versions.SelectedIndexChanged += new System.EventHandler(this.comboBox_Versions_SelectedIndexChanged);
            // 
            // textBox_Path
            // 
            this.textBox_Path.Enabled = false;
            this.textBox_Path.Location = new System.Drawing.Point(9, 489);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(198, 20);
            this.textBox_Path.TabIndex = 3;
            this.textBox_Path.Text = "%appdata%\\.minecraft\\ElementalRealms";
            this.textBox_Path.Visible = false;
            this.textBox_Path.TextChanged += new System.EventHandler(this.textBox_Path_TextChanged);
            // 
            // button_Path
            // 
            this.button_Path.Enabled = false;
            this.button_Path.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Path.Location = new System.Drawing.Point(213, 488);
            this.button_Path.Name = "button_Path";
            this.button_Path.Size = new System.Drawing.Size(25, 25);
            this.button_Path.TabIndex = 4;
            this.button_Path.Text = "..";
            this.button_Path.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Path.UseVisualStyleBackColor = true;
            this.button_Path.Click += new System.EventHandler(this.button_Path_Click);
            // 
            // button_Install
            // 
            this.button_Install.BackColor = System.Drawing.Color.Transparent;
            this.button_Install.Enabled = false;
            this.button_Install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Install.Location = new System.Drawing.Point(894, 509);
            this.button_Install.Name = "button_Install";
            this.button_Install.Size = new System.Drawing.Size(140, 62);
            this.button_Install.TabIndex = 6;
            this.button_Install.Text = "Install/Update";
            this.button_Install.UseVisualStyleBackColor = false;
            this.button_Install.Click += new System.EventHandler(this.button_Install_Click);
            // 
            // checkBox_Dev
            // 
            this.checkBox_Dev.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_Dev.AutoSize = true;
            this.checkBox_Dev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Dev.Location = new System.Drawing.Point(66, 313);
            this.checkBox_Dev.Name = "checkBox_Dev";
            this.checkBox_Dev.Size = new System.Drawing.Size(138, 17);
            this.checkBox_Dev.TabIndex = 7;
            this.checkBox_Dev.Text = "Enable Dev Pack Builds";
            this.checkBox_Dev.UseVisualStyleBackColor = true;
            this.checkBox_Dev.CheckedChanged += new System.EventHandler(this.checkBox_Dev_CheckedChanged);
            // 
            // checkBox_Log
            // 
            this.checkBox_Log.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_Log.AutoSize = true;
            this.checkBox_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Log.Location = new System.Drawing.Point(66, 336);
            this.checkBox_Log.Name = "checkBox_Log";
            this.checkBox_Log.Size = new System.Drawing.Size(109, 17);
            this.checkBox_Log.TabIndex = 8;
            this.checkBox_Log.Text = "Launcher Console";
            this.checkBox_Log.UseVisualStyleBackColor = true;
            this.checkBox_Log.CheckedChanged += new System.EventHandler(this.checkBox_Log_CheckedChanged);
            // 
            // checkBox_Biome
            // 
            this.checkBox_Biome.AccessibleDescription = "";
            this.checkBox_Biome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_Biome.AutoSize = true;
            this.checkBox_Biome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Biome.Location = new System.Drawing.Point(66, 290);
            this.checkBox_Biome.Name = "checkBox_Biome";
            this.checkBox_Biome.Size = new System.Drawing.Size(118, 17);
            this.checkBox_Biome.TabIndex = 10;
            this.checkBox_Biome.Text = "Custom Biomes (SP)";
            this.checkBox_Biome.UseVisualStyleBackColor = true;
            this.checkBox_Biome.CheckedChanged += new System.EventHandler(this.checkBox_Biome_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // checkBox_Fresh
            // 
            this.checkBox_Fresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox_Fresh.AutoSize = true;
            this.checkBox_Fresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Fresh.Location = new System.Drawing.Point(66, 359);
            this.checkBox_Fresh.Name = "checkBox_Fresh";
            this.checkBox_Fresh.Size = new System.Drawing.Size(80, 17);
            this.checkBox_Fresh.TabIndex = 11;
            this.checkBox_Fresh.Text = "Clean Install";
            this.checkBox_Fresh.UseVisualStyleBackColor = true;
            this.checkBox_Fresh.CheckedChanged += new System.EventHandler(this.checkBox_Fresh_CheckedChanged);
            // 
            // checkBox_Timer
            // 
            this.checkBox_Timer.AutoSize = true;
            this.checkBox_Timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Timer.Location = new System.Drawing.Point(102, 451);
            this.checkBox_Timer.Name = "checkBox_Timer";
            this.checkBox_Timer.Size = new System.Drawing.Size(86, 17);
            this.checkBox_Timer.TabIndex = 12;
            this.checkBox_Timer.Text = "Auto Update:";
            this.checkBox_Timer.UseVisualStyleBackColor = true;
            this.checkBox_Timer.CheckedChanged += new System.EventHandler(this.checkBox_Timer_CheckedChanged);
            // 
            // textBox1_time
            // 
            this.textBox1_time.Location = new System.Drawing.Point(33, 448);
            this.textBox1_time.Name = "textBox1_time";
            this.textBox1_time.Size = new System.Drawing.Size(63, 20);
            this.textBox1_time.TabIndex = 13;
            this.textBox1_time.Text = "30";
            this.textBox1_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1_time.Visible = false;
            this.textBox1_time.TextChanged += new System.EventHandler(this.textBox1_time_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_Modpack
            // 
            this.button_Modpack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Modpack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Modpack.Location = new System.Drawing.Point(443, 17);
            this.button_Modpack.Name = "button_Modpack";
            this.button_Modpack.Size = new System.Drawing.Size(154, 25);
            this.button_Modpack.TabIndex = 15;
            this.button_Modpack.Text = "Add Modpack";
            this.button_Modpack.UseVisualStyleBackColor = true;
            this.button_Modpack.Click += new System.EventHandler(this.button_Modpack_Click);
            // 
            // ERnotifyIcon
            // 
            this.ERnotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ERnotifyIcon.Icon")));
            this.ERnotifyIcon.Click += new System.EventHandler(this.ERnotifyIcon_Click);
            // 
            // Settings_panel
            // 
            this.Settings_panel.BackColor = System.Drawing.Color.DodgerBlue;
            this.Settings_panel.Controls.Add(this.tableLayoutPanel2);
            this.Settings_panel.Controls.Add(this.checkBox_Dev);
            this.Settings_panel.Controls.Add(this.checkBox_Log);
            this.Settings_panel.Controls.Add(this.checkBox_Fresh);
            this.Settings_panel.Controls.Add(this.checkBox_Biome);
            this.Settings_panel.Controls.Add(this.textBox1_time);
            this.Settings_panel.Controls.Add(this.textBox_Path);
            this.Settings_panel.Controls.Add(this.button_Path);
            this.Settings_panel.Controls.Add(this.checkBox_Timer);
            this.Settings_panel.Location = new System.Drawing.Point(1040, 80);
            this.Settings_panel.Name = "Settings_panel";
            this.Settings_panel.Size = new System.Drawing.Size(260, 520);
            this.Settings_panel.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.setings_button, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(189, 254);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // setings_button
            // 
            this.setings_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.setings_button.Image = ((System.Drawing.Image)(resources.GetObject("setings_button.Image")));
            this.setings_button.Location = new System.Drawing.Point(3, 5);
            this.setings_button.Name = "setings_button";
            this.setings_button.Size = new System.Drawing.Size(50, 50);
            this.setings_button.TabIndex = 0;
            this.setings_button.TabStop = false;
            this.setings_button.Click += new System.EventHandler(this.setings_button_Click);
            // 
            // comboBox_Pack
            // 
            this.comboBox_Pack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Pack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Pack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Pack.FormattingEnabled = true;
            this.comboBox_Pack.Location = new System.Drawing.Point(263, 19);
            this.comboBox_Pack.Name = "comboBox_Pack";
            this.comboBox_Pack.Size = new System.Drawing.Size(174, 21);
            this.comboBox_Pack.TabIndex = 14;
            this.comboBox_Pack.SelectedIndexChanged += new System.EventHandler(this.comboBox_Pack_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 80);
            this.panel2.TabIndex = 19;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Pack, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.temp_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Modpack, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.to_tray, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_ERlogo, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1053, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseUp);
            // 
            // temp_name
            // 
            this.temp_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.temp_name.AutoSize = true;
            this.temp_name.BackColor = System.Drawing.Color.Transparent;
            this.temp_name.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_name.ForeColor = System.Drawing.Color.SeaShell;
            this.temp_name.Location = new System.Drawing.Point(73, 17);
            this.temp_name.Name = "temp_name";
            this.temp_name.Size = new System.Drawing.Size(179, 25);
            this.temp_name.TabIndex = 15;
            this.temp_name.Text = "Elemental launcher ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(983, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // to_tray
            // 
            this.to_tray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.to_tray.Image = ((System.Drawing.Image)(resources.GetObject("to_tray.Image")));
            this.to_tray.Location = new System.Drawing.Point(923, 5);
            this.to_tray.Name = "to_tray";
            this.to_tray.Size = new System.Drawing.Size(50, 50);
            this.to_tray.TabIndex = 25;
            this.to_tray.TabStop = false;
            this.to_tray.Click += new System.EventHandler(this.to_tray_Click);
            // 
            // pictureBox_ERlogo
            // 
            this.pictureBox_ERlogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ERlogo.Image = global::MC_Client.Properties.Resources.ERlogo;
            this.pictureBox_ERlogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_ERlogo.MaximumSize = new System.Drawing.Size(64, 64);
            this.pictureBox_ERlogo.MinimumSize = new System.Drawing.Size(64, 64);
            this.pictureBox_ERlogo.Name = "pictureBox_ERlogo";
            this.pictureBox_ERlogo.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_ERlogo.TabIndex = 26;
            this.pictureBox_ERlogo.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.progressBar1.Location = new System.Drawing.Point(0, 577);
            this.progressBar1.Maximum = 1200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1034, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 24;
            // 
            // label_version
            // 
            this.label_version.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_version.AutoSize = true;
            this.label_version.BackColor = System.Drawing.Color.Transparent;
            this.label_version.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_version.Location = new System.Drawing.Point(5, 339);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(80, 25);
            this.label_version.TabIndex = 25;
            this.label_version.Text = "Version:";
            // 
            // label_InstalledV
            // 
            this.label_InstalledV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_InstalledV.AutoSize = true;
            this.label_InstalledV.BackColor = System.Drawing.Color.Transparent;
            this.label_InstalledV.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InstalledV.Location = new System.Drawing.Point(12, 364);
            this.label_InstalledV.Name = "label_InstalledV";
            this.label_InstalledV.Size = new System.Drawing.Size(111, 19);
            this.label_InstalledV.TabIndex = 26;
            this.label_InstalledV.Text = "Installed version:";
            // 
            // pictureBox_PackLogo
            // 
            this.pictureBox_PackLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PackLogo.Location = new System.Drawing.Point(12, 90);
            this.pictureBox_PackLogo.Name = "pictureBox_PackLogo";
            this.pictureBox_PackLogo.Size = new System.Drawing.Size(240, 240);
            this.pictureBox_PackLogo.TabIndex = 27;
            this.pictureBox_PackLogo.TabStop = false;
            // 
            // Form_ER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.pictureBox_PackLogo);
            this.Controls.Add(this.label_InstalledV);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Settings_panel);
            this.Controls.Add(this.button_Install);
            this.Controls.Add(this.comboBox_Versions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 600);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "Form_ER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elemental Installer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ER_FormClosing);
            this.Load += new System.EventHandler(this.Form_ER_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form_ER_MouseClick);
            this.Settings_panel.ResumeLayout(false);
            this.Settings_panel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setings_button)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.to_tray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ERlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PackLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_Versions;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Button button_Path;
        private System.Windows.Forms.Button button_Install;
        private System.Windows.Forms.CheckBox checkBox_Dev;
        private System.Windows.Forms.CheckBox checkBox_Log;
        private System.Windows.Forms.CheckBox checkBox_Biome;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBox_Fresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox_Timer;
        private System.Windows.Forms.TextBox textBox1_time;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_Modpack;
        private System.Windows.Forms.NotifyIcon ERnotifyIcon;
        private System.Windows.Forms.Panel Settings_panel;
        private System.Windows.Forms.ComboBox comboBox_Pack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label temp_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox to_tray;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox setings_button;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label_InstalledV;
        private System.Windows.Forms.PictureBox pictureBox_ERlogo;
        private System.Windows.Forms.PictureBox pictureBox_PackLogo;
    }
}


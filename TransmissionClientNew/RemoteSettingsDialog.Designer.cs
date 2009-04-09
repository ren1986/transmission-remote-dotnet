﻿namespace TransmissionRemoteDotnet
{
    partial class RemoteSettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteSettingsDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.DownloadToField = new System.Windows.Forms.TextBox();
            this.LimitUploadCheckBox = new System.Windows.Forms.CheckBox();
            this.LimitUploadValue = new System.Windows.Forms.NumericUpDown();
            this.LimitDownloadCheckBox = new System.Windows.Forms.CheckBox();
            this.LimitDownloadValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.IncomingPortValue = new System.Windows.Forms.NumericUpDown();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.SettingsWorker = new System.ComponentModel.BackgroundWorker();
            this.PeerLimitValue = new System.Windows.Forms.NumericUpDown();
            this.PEXcheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PortForward = new System.Windows.Forms.CheckBox();
            this.EncryptionCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.updateBlocklistButton = new System.Windows.Forms.Button();
            this.blocklistEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.seedLimitUpDown = new System.Windows.Forms.NumericUpDown();
            this.seedRatioEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.altTimeConstraintEndField = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.altTimeConstraintStartField = new System.Windows.Forms.NumericUpDown();
            this.altUploadLimitField = new System.Windows.Forms.NumericUpDown();
            this.altDownloadLimitField = new System.Windows.Forms.NumericUpDown();
            this.altTimeConstraintEnabled = new System.Windows.Forms.CheckBox();
            this.altSpeedLimitEnable = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.testPortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LimitUploadValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimitDownloadValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomingPortValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeerLimitValue)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seedLimitUpDown)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altTimeConstraintEndField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altTimeConstraintStartField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altUploadLimitField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altDownloadLimitField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // DownloadToField
            // 
            resources.ApplyResources(this.DownloadToField, "DownloadToField");
            this.DownloadToField.Name = "DownloadToField";
            // 
            // LimitUploadCheckBox
            // 
            resources.ApplyResources(this.LimitUploadCheckBox, "LimitUploadCheckBox");
            this.LimitUploadCheckBox.Name = "LimitUploadCheckBox";
            this.LimitUploadCheckBox.UseVisualStyleBackColor = true;
            this.LimitUploadCheckBox.CheckedChanged += new System.EventHandler(this.LimitUploadCheckBox_CheckedChanged);
            // 
            // LimitUploadValue
            // 
            resources.ApplyResources(this.LimitUploadValue, "LimitUploadValue");
            this.LimitUploadValue.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.LimitUploadValue.Name = "LimitUploadValue";
            // 
            // LimitDownloadCheckBox
            // 
            resources.ApplyResources(this.LimitDownloadCheckBox, "LimitDownloadCheckBox");
            this.LimitDownloadCheckBox.Name = "LimitDownloadCheckBox";
            this.LimitDownloadCheckBox.UseVisualStyleBackColor = true;
            this.LimitDownloadCheckBox.CheckedChanged += new System.EventHandler(this.LimitDownloadCheckBox_CheckedChanged);
            // 
            // LimitDownloadValue
            // 
            resources.ApplyResources(this.LimitDownloadValue, "LimitDownloadValue");
            this.LimitDownloadValue.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.LimitDownloadValue.Name = "LimitDownloadValue";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // IncomingPortValue
            // 
            resources.ApplyResources(this.IncomingPortValue, "IncomingPortValue");
            this.IncomingPortValue.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.IncomingPortValue.Name = "IncomingPortValue";
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.CloseFormButton, "CloseFormButton");
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // SettingsWorker
            // 
            this.SettingsWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SettingsWorker_DoWork);
            this.SettingsWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SettingsWorker_RunWorkerCompleted);
            // 
            // PeerLimitValue
            // 
            resources.ApplyResources(this.PeerLimitValue, "PeerLimitValue");
            this.PeerLimitValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PeerLimitValue.Name = "PeerLimitValue";
            // 
            // PEXcheckBox
            // 
            resources.ApplyResources(this.PEXcheckBox, "PEXcheckBox");
            this.PEXcheckBox.Name = "PEXcheckBox";
            this.PEXcheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // PortForward
            // 
            resources.ApplyResources(this.PortForward, "PortForward");
            this.PortForward.Name = "PortForward";
            this.PortForward.UseVisualStyleBackColor = true;
            // 
            // EncryptionCombobox
            // 
            this.EncryptionCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncryptionCombobox.FormattingEnabled = true;
            this.EncryptionCombobox.Items.AddRange(new object[] {
            resources.GetString("EncryptionCombobox.Items"),
            resources.GetString("EncryptionCombobox.Items1"),
            resources.GetString("EncryptionCombobox.Items2")});
            resources.ApplyResources(this.EncryptionCombobox, "EncryptionCombobox");
            this.EncryptionCombobox.Name = "EncryptionCombobox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.testPortButton);
            this.tabPage1.Controls.Add(this.updateBlocklistButton);
            this.tabPage1.Controls.Add(this.blocklistEnabledCheckBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.PEXcheckBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.IncomingPortValue);
            this.tabPage1.Controls.Add(this.PortForward);
            this.tabPage1.Controls.Add(this.DownloadToField);
            this.tabPage1.Controls.Add(this.EncryptionCombobox);
            this.tabPage1.Controls.Add(this.label3);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // updateBlocklistButton
            // 
            resources.ApplyResources(this.updateBlocklistButton, "updateBlocklistButton");
            this.updateBlocklistButton.Name = "updateBlocklistButton";
            this.updateBlocklistButton.UseVisualStyleBackColor = true;
            this.updateBlocklistButton.Click += new System.EventHandler(this.updateBlocklistButton_Click);
            // 
            // blocklistEnabledCheckBox
            // 
            resources.ApplyResources(this.blocklistEnabledCheckBox, "blocklistEnabledCheckBox");
            this.blocklistEnabledCheckBox.Name = "blocklistEnabledCheckBox";
            this.blocklistEnabledCheckBox.UseVisualStyleBackColor = true;
            this.blocklistEnabledCheckBox.CheckedChanged += new System.EventHandler(this.blocklistEnabledCheckBox_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.seedLimitUpDown);
            this.tabPage2.Controls.Add(this.seedRatioEnabledCheckBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.LimitUploadCheckBox);
            this.tabPage2.Controls.Add(this.PeerLimitValue);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.LimitUploadValue);
            this.tabPage2.Controls.Add(this.LimitDownloadValue);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.LimitDownloadCheckBox);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // seedLimitUpDown
            // 
            this.seedLimitUpDown.DecimalPlaces = 2;
            resources.ApplyResources(this.seedLimitUpDown, "seedLimitUpDown");
            this.seedLimitUpDown.Name = "seedLimitUpDown";
            // 
            // seedRatioEnabledCheckBox
            // 
            resources.ApplyResources(this.seedRatioEnabledCheckBox, "seedRatioEnabledCheckBox");
            this.seedRatioEnabledCheckBox.Name = "seedRatioEnabledCheckBox";
            this.seedRatioEnabledCheckBox.UseVisualStyleBackColor = true;
            this.seedRatioEnabledCheckBox.CheckedChanged += new System.EventHandler(this.seedRatioEnabledCheckBox_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.altTimeConstraintEndField);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.altTimeConstraintStartField);
            this.tabPage3.Controls.Add(this.altUploadLimitField);
            this.tabPage3.Controls.Add(this.altDownloadLimitField);
            this.tabPage3.Controls.Add(this.altTimeConstraintEnabled);
            this.tabPage3.Controls.Add(this.altSpeedLimitEnable);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            resources.GetString("listBox1.Items"),
            resources.GetString("listBox1.Items1"),
            resources.GetString("listBox1.Items2"),
            resources.GetString("listBox1.Items3"),
            resources.GetString("listBox1.Items4"),
            resources.GetString("listBox1.Items5"),
            resources.GetString("listBox1.Items6"),
            resources.GetString("listBox1.Items7"),
            resources.GetString("listBox1.Items8"),
            resources.GetString("listBox1.Items9")});
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // altTimeConstraintEndField
            // 
            resources.ApplyResources(this.altTimeConstraintEndField, "altTimeConstraintEndField");
            this.altTimeConstraintEndField.Name = "altTimeConstraintEndField";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // altTimeConstraintStartField
            // 
            resources.ApplyResources(this.altTimeConstraintStartField, "altTimeConstraintStartField");
            this.altTimeConstraintStartField.Name = "altTimeConstraintStartField";
            // 
            // altUploadLimitField
            // 
            resources.ApplyResources(this.altUploadLimitField, "altUploadLimitField");
            this.altUploadLimitField.Name = "altUploadLimitField";
            // 
            // altDownloadLimitField
            // 
            resources.ApplyResources(this.altDownloadLimitField, "altDownloadLimitField");
            this.altDownloadLimitField.Name = "altDownloadLimitField";
            // 
            // altTimeConstraintEnabled
            // 
            resources.ApplyResources(this.altTimeConstraintEnabled, "altTimeConstraintEnabled");
            this.altTimeConstraintEnabled.Name = "altTimeConstraintEnabled";
            this.altTimeConstraintEnabled.UseVisualStyleBackColor = true;
            this.altTimeConstraintEnabled.CheckedChanged += new System.EventHandler(this.altTimeConstraintEnabled_CheckedChanged);
            // 
            // altSpeedLimitEnable
            // 
            resources.ApplyResources(this.altSpeedLimitEnable, "altSpeedLimitEnable");
            this.altSpeedLimitEnable.Name = "altSpeedLimitEnable";
            this.altSpeedLimitEnable.UseVisualStyleBackColor = true;
            this.altSpeedLimitEnable.CheckedChanged += new System.EventHandler(this.altSpeedLimitEnable_CheckedChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // testPortButton
            // 
            resources.ApplyResources(this.testPortButton, "testPortButton");
            this.testPortButton.Name = "testPortButton";
            this.testPortButton.UseVisualStyleBackColor = true;
            this.testPortButton.Click += new System.EventHandler(this.testPortButton_Click);
            // 
            // RemoteSettingsDialog
            // 
            this.AcceptButton = this.SaveButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseFormButton;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RemoteSettingsDialog";
            this.Load += new System.EventHandler(this.RemoteSettingsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LimitUploadValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LimitDownloadValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomingPortValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeerLimitValue)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seedLimitUpDown)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altTimeConstraintEndField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altTimeConstraintStartField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altUploadLimitField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altDownloadLimitField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DownloadToField;
        private System.Windows.Forms.CheckBox LimitUploadCheckBox;
        private System.Windows.Forms.NumericUpDown LimitUploadValue;
        private System.Windows.Forms.CheckBox LimitDownloadCheckBox;
        private System.Windows.Forms.NumericUpDown LimitDownloadValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown IncomingPortValue;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseFormButton;
        private System.ComponentModel.BackgroundWorker SettingsWorker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EncryptionCombobox;
        private System.Windows.Forms.CheckBox PortForward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox PEXcheckBox;
        private System.Windows.Forms.NumericUpDown PeerLimitValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox altTimeConstraintEnabled;
        private System.Windows.Forms.CheckBox altSpeedLimitEnable;
        private System.Windows.Forms.NumericUpDown altTimeConstraintEndField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown altTimeConstraintStartField;
        private System.Windows.Forms.NumericUpDown altUploadLimitField;
        private System.Windows.Forms.NumericUpDown altDownloadLimitField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox blocklistEnabledCheckBox;
        private System.Windows.Forms.Button updateBlocklistButton;
        private System.Windows.Forms.NumericUpDown seedLimitUpDown;
        private System.Windows.Forms.CheckBox seedRatioEnabledCheckBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button testPortButton;
    }
}
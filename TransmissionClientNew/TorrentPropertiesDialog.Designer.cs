// transmission-remote-dotnet
// http://code.google.com/p/transmission-remote-dotnet/
// Copyright (C) 2009 Alan F
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

﻿namespace TransmissionRemoteDotnet
{
    partial class TorrentPropertiesDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TorrentPropertiesDialog));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.honorsSessionLimits = new System.Windows.Forms.CheckBox();
            this.seedRatioLimitedCheckBox = new System.Windows.Forms.CheckBox();
            this.seedRatioLimitValue = new System.Windows.Forms.NumericUpDown();
            this.peerLimitValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.uploadLimitEnableField = new System.Windows.Forms.CheckBox();
            this.downloadLimitField = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.uploadLimitField = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.downloadLimitEnableField = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seedRatioLimitValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peerLimitValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadLimitField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uploadLimitField)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.honorsSessionLimits);
            this.tabPage1.Controls.Add(this.seedRatioLimitedCheckBox);
            this.tabPage1.Controls.Add(this.seedRatioLimitValue);
            this.tabPage1.Controls.Add(this.peerLimitValue);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.uploadLimitEnableField);
            this.tabPage1.Controls.Add(this.downloadLimitField);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.uploadLimitField);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.downloadLimitEnableField);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // honorsSessionLimits
            // 
            resources.ApplyResources(this.honorsSessionLimits, "honorsSessionLimits");
            this.honorsSessionLimits.Name = "honorsSessionLimits";
            this.honorsSessionLimits.UseVisualStyleBackColor = true;
            // 
            // seedRatioLimitedCheckBox
            // 
            resources.ApplyResources(this.seedRatioLimitedCheckBox, "seedRatioLimitedCheckBox");
            this.seedRatioLimitedCheckBox.Name = "seedRatioLimitedCheckBox";
            this.seedRatioLimitedCheckBox.UseVisualStyleBackColor = true;
            // 
            // seedRatioLimitValue
            // 
            this.seedRatioLimitValue.DecimalPlaces = 2;
            resources.ApplyResources(this.seedRatioLimitValue, "seedRatioLimitValue");
            this.seedRatioLimitValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.seedRatioLimitValue.Name = "seedRatioLimitValue";
            // 
            // peerLimitValue
            // 
            resources.ApplyResources(this.peerLimitValue, "peerLimitValue");
            this.peerLimitValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.peerLimitValue.Name = "peerLimitValue";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // uploadLimitEnableField
            // 
            resources.ApplyResources(this.uploadLimitEnableField, "uploadLimitEnableField");
            this.uploadLimitEnableField.Name = "uploadLimitEnableField";
            this.uploadLimitEnableField.UseVisualStyleBackColor = true;
            this.uploadLimitEnableField.CheckedChanged += new System.EventHandler(this.uploadLimitEnableField_CheckedChanged);
            // 
            // downloadLimitField
            // 
            resources.ApplyResources(this.downloadLimitField, "downloadLimitField");
            this.downloadLimitField.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.downloadLimitField.Name = "downloadLimitField";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // uploadLimitField
            // 
            resources.ApplyResources(this.uploadLimitField, "uploadLimitField");
            this.uploadLimitField.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.uploadLimitField.Name = "uploadLimitField";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // downloadLimitEnableField
            // 
            resources.ApplyResources(this.downloadLimitEnableField, "downloadLimitEnableField");
            this.downloadLimitEnableField.Name = "downloadLimitEnableField";
            this.downloadLimitEnableField.UseVisualStyleBackColor = true;
            this.downloadLimitEnableField.CheckedChanged += new System.EventHandler(this.downloadLimitEnableField_CheckedChanged);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // TorrentPropertiesDialog
            // 
            this.AcceptButton = this.button1;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TorrentPropertiesDialog";
            this.Load += new System.EventHandler(this.TorrentPropertiesDialog_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seedRatioLimitValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peerLimitValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadLimitField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uploadLimitField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown downloadLimitField;
        private System.Windows.Forms.NumericUpDown uploadLimitField;
        private System.Windows.Forms.CheckBox downloadLimitEnableField;
        private System.Windows.Forms.CheckBox uploadLimitEnableField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown peerLimitValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown seedRatioLimitValue;
        private System.Windows.Forms.CheckBox seedRatioLimitedCheckBox;
        private System.Windows.Forms.CheckBox honorsSessionLimits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;


    }
}
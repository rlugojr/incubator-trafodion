// @@@ START COPYRIGHT @@@
//
// (C) Copyright 2015 Hewlett-Packard Development Company, L.P.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
// @@@ END COPYRIGHT @@@
﻿namespace Trafodion.Manager.SecurityArea.Controls
{
    partial class ManageUserDialog
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
            this._theMainPanel = new Trafodion.Manager.Framework.Controls.TrafodionPanel();
            this._theControlPanel = new Trafodion.Manager.Framework.Controls.TrafodionPanel();
            this._theMessagePanel = new Trafodion.Manager.Framework.Controls.TrafodionMessagePanel();
            this._theButtonPanel = new Trafodion.Manager.Framework.Controls.TrafodionPanel();
            this.oneGuiPanel1 = new Trafodion.Manager.Framework.Controls.TrafodionPanel();
            this._theOkButton = new Trafodion.Manager.Framework.Controls.TrafodionButton();
            this._theCancelButton = new Trafodion.Manager.Framework.Controls.TrafodionButton();
            this._theMainPanel.SuspendLayout();
            this._theButtonPanel.SuspendLayout();
            this.oneGuiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _theMainPanel
            // 
            this._theMainPanel.AutoSize = true;
            this._theMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._theMainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this._theMainPanel.Controls.Add(this._theControlPanel);
            this._theMainPanel.Controls.Add(this._theMessagePanel);
            this._theMainPanel.Controls.Add(this._theButtonPanel);
            this._theMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._theMainPanel.Location = new System.Drawing.Point(0, 0);
            this._theMainPanel.Name = "_theMainPanel";
            this._theMainPanel.Size = new System.Drawing.Size(507, 510);
            this._theMainPanel.TabIndex = 0;
            // 
            // _theControlPanel
            // 
            this._theControlPanel.AutoSize = true;
            this._theControlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._theControlPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this._theControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._theControlPanel.Location = new System.Drawing.Point(0, 22);
            this._theControlPanel.Name = "_theControlPanel";
            this._theControlPanel.Size = new System.Drawing.Size(507, 448);
            this._theControlPanel.TabIndex = 1;
            // 
            // _theMessagePanel
            // 
            this._theMessagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._theMessagePanel.Location = new System.Drawing.Point(0, 0);
            this._theMessagePanel.Name = "_theMessagePanel";
            this._theMessagePanel.Size = new System.Drawing.Size(507, 22);
            this._theMessagePanel.TabIndex = 0;
            // 
            // _theButtonPanel
            // 
            this._theButtonPanel.AutoSize = true;
            this._theButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._theButtonPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this._theButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._theButtonPanel.Controls.Add(this.oneGuiPanel1);
            this._theButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._theButtonPanel.Location = new System.Drawing.Point(0, 470);
            this._theButtonPanel.Name = "_theButtonPanel";
            this._theButtonPanel.Size = new System.Drawing.Size(507, 40);
            this._theButtonPanel.TabIndex = 0;
            // 
            // oneGuiPanel1
            // 
            this.oneGuiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.oneGuiPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.oneGuiPanel1.Controls.Add(this._theOkButton);
            this.oneGuiPanel1.Controls.Add(this._theCancelButton);
            this.oneGuiPanel1.Location = new System.Drawing.Point(333, 4);
            this.oneGuiPanel1.Name = "oneGuiPanel1";
            this.oneGuiPanel1.Size = new System.Drawing.Size(167, 29);
            this.oneGuiPanel1.TabIndex = 2;
            // 
            // _theOkButton
            // 
            this._theOkButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this._theOkButton.Location = new System.Drawing.Point(3, 3);
            this._theOkButton.Name = "_theOkButton";
            this._theOkButton.Size = new System.Drawing.Size(75, 23);
            this._theOkButton.TabIndex = 0;
            this._theOkButton.Text = "&OK";
            this._theOkButton.UseVisualStyleBackColor = true;
            this._theOkButton.Click += new System.EventHandler(this._theOkButton_Click);
            // 
            // _theCancelButton
            // 
            this._theCancelButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this._theCancelButton.Location = new System.Drawing.Point(89, 3);
            this._theCancelButton.Name = "_theCancelButton";
            this._theCancelButton.Size = new System.Drawing.Size(75, 23);
            this._theCancelButton.TabIndex = 1;
            this._theCancelButton.Text = "&Cancel";
            this._theCancelButton.UseVisualStyleBackColor = true;
            this._theCancelButton.Click += new System.EventHandler(this._theCancelButton_Click);
            // 
            // ManageUserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(507, 510);
            this.Controls.Add(this._theMainPanel);
            this.Name = "ManageUserDialog";
            this.Text = "HP Database Manager - ManageUserDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageUserDialog_FormClosing);
            this._theMainPanel.ResumeLayout(false);
            this._theMainPanel.PerformLayout();
            this._theButtonPanel.ResumeLayout(false);
            this.oneGuiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Trafodion.Manager.Framework.Controls.TrafodionPanel _theMainPanel;
        private Trafodion.Manager.Framework.Controls.TrafodionPanel _theControlPanel;
        private Trafodion.Manager.Framework.Controls.TrafodionPanel _theButtonPanel;
        private Trafodion.Manager.Framework.Controls.TrafodionButton _theCancelButton;
        private Trafodion.Manager.Framework.Controls.TrafodionButton _theOkButton;
        private Trafodion.Manager.Framework.Controls.TrafodionPanel oneGuiPanel1;
        private Trafodion.Manager.Framework.Controls.TrafodionMessagePanel _theMessagePanel;
    }
}
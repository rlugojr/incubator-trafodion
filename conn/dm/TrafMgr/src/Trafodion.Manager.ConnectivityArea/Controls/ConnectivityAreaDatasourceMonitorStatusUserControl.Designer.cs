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
﻿namespace Trafodion.Manager.ConnectivityArea.Controls
{
    partial class ConnectivityAreaDatasourceMonitorStatusUserControl
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
            MyDispose();
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TrafodionPanel1 = new Trafodion.Manager.Framework.Controls.TrafodionPanel();
            this._bottomPanel = new Trafodion.Manager.Framework.Controls.TrafodionPanel();
            this._bottomLeftPanel = new Trafodion.Manager.Framework.Controls.TrafodionPanel();
            this._startButton = new Trafodion.Manager.Framework.Controls.TrafodionButton();
            this._stopButton = new Trafodion.Manager.Framework.Controls.TrafodionButton();
            this._refreshButton = new Trafodion.Manager.Framework.Controls.TrafodionButton();
            this._applyButton = new Trafodion.Manager.Framework.Controls.TrafodionButton();
            this._bottomRightPanel = new Trafodion.Manager.Framework.Controls.TrafodionPanel();
            this._bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrafodionPanel1
            // 
            this.TrafodionPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrafodionPanel1.Location = new System.Drawing.Point(0, 0);
            this.TrafodionPanel1.Name = "TrafodionPanel1";
            this.TrafodionPanel1.Size = new System.Drawing.Size(710, 307);
            this.TrafodionPanel1.TabIndex = 52;
            // 
            // _bottomPanel
            // 
            this._bottomPanel.Controls.Add(this._bottomRightPanel);
            this._bottomPanel.Controls.Add(this._bottomLeftPanel);
            this._bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._bottomPanel.Location = new System.Drawing.Point(0, 307);
            this._bottomPanel.Name = "_bottomPanel";
            this._bottomPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._bottomPanel.Size = new System.Drawing.Size(710, 31);
            this._bottomPanel.TabIndex = 53;
            // 
            // _bottomLeftPanel
            // 
            this._bottomLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._bottomLeftPanel.Location = new System.Drawing.Point(0, 0);
            this._bottomLeftPanel.Name = "_bottomLeftPanel";
            this._bottomLeftPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._bottomLeftPanel.Size = new System.Drawing.Size(331, 31);
            this._bottomLeftPanel.TabIndex = 5;
            // 
            // _startButton
            // 
            this._startButton.Location = new System.Drawing.Point(3, 4);
            this._startButton.Name = "_startButton";
            this._startButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._startButton.Size = new System.Drawing.Size(52, 23);
            this._startButton.TabIndex = 1;
            this._startButton.Text = "S&tart";
            this._startButton.UseVisualStyleBackColor = true;
            this._startButton.Click += new System.EventHandler(this._startButton_Click);
            // 
            // _stopButton
            // 
            this._stopButton.Location = new System.Drawing.Point(60, 4);
            this._stopButton.Name = "_stopButton";
            this._stopButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._stopButton.Size = new System.Drawing.Size(52, 23);
            this._stopButton.TabIndex = 2;
            this._stopButton.Text = "Sto&p...";
            this._stopButton.UseVisualStyleBackColor = true;
            this._stopButton.Click += new System.EventHandler(this._stopButton_Click);
            // 
            // _refreshButton
            // 
            this._refreshButton.Location = new System.Drawing.Point(117, 4);
            this._refreshButton.Name = "_refreshButton";
            this._refreshButton.Size = new System.Drawing.Size(60, 23);
            this._refreshButton.TabIndex = 3;
            this._refreshButton.Text = "&Refresh";
            this._refreshButton.UseVisualStyleBackColor = true;
            this._refreshButton.Click += new System.EventHandler(this._refreshButton_Click);
            // 
            // _applyButton
            // 
            this._applyButton.Location = new System.Drawing.Point(174, 4);
            this._applyButton.Name = "_applyButton";
            this._applyButton.Size = new System.Drawing.Size(52, 23);
            this._applyButton.TabIndex = 4;
            this._applyButton.Text = "&Apply";
            this._applyButton.UseVisualStyleBackColor = true;
            this._applyButton.Click += new System.EventHandler(this._applyButton_Click);
            // 
            // _bottomRightPanel
            // 
            this._bottomRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this._bottomRightPanel.Location = new System.Drawing.Point(252, 0);
            this._bottomRightPanel.Name = "_bottomRightPanel";
            this._bottomRightPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._bottomRightPanel.Size = new System.Drawing.Size(458, 31);
            this._bottomRightPanel.TabIndex = 7;
            // 
            // ConnectivityAreaDatasourceMonitorStatusUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TrafodionPanel1);
            this.Controls.Add(this._bottomPanel);
            this.Name = "ConnectivityAreaDatasourceMonitorStatusUserControl";
            this.Size = new System.Drawing.Size(710, 338);
            this._bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Trafodion.Manager.Framework.Controls.TrafodionPanel TrafodionPanel1;
        private Trafodion.Manager.Framework.Controls.TrafodionPanel _bottomPanel;
        private Trafodion.Manager.Framework.Controls.TrafodionPanel _bottomLeftPanel;
        private Trafodion.Manager.Framework.Controls.TrafodionButton _startButton;
        private Trafodion.Manager.Framework.Controls.TrafodionButton _stopButton;
        private Trafodion.Manager.Framework.Controls.TrafodionButton _refreshButton;
        private Trafodion.Manager.Framework.Controls.TrafodionButton _applyButton;
        private Trafodion.Manager.Framework.Controls.TrafodionPanel _bottomRightPanel;

    }
}

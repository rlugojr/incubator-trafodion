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
using Trafodion.Manager.Framework.Controls;

namespace Trafodion.Manager.DatabaseArea.Queries.Controls
{
    partial class DefaultReportParameterInput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.paramCombo = new Trafodion.Manager.Framework.Controls.TrafodionComboBox();
            this.paramGroup = new Trafodion.Manager.Framework.Controls.TrafodionGroupBox();
            this.paramToolTip = new Trafodion.Manager.Framework.Controls.TrafodionToolTip(this.components);
            this.paramGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // paramCombo
            // 
            this.paramCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paramCombo.Font = new System.Drawing.Font("Tahoma", 8F);
            this.paramCombo.FormattingEnabled = true;
            this.paramCombo.Location = new System.Drawing.Point(4, 16);
            this.paramCombo.Margin = new System.Windows.Forms.Padding(4, 4, 12, 6);
            this.paramCombo.Name = "paramCombo";
            this.paramCombo.Size = new System.Drawing.Size(435, 24);
            this.paramCombo.TabIndex = 0;
            this.paramCombo.TextChanged += new System.EventHandler(this.paramCombo_TextChanged);
            // 
            // paramGroup
            // 
            this.paramGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paramGroup.Controls.Add(this.paramCombo);
            this.paramGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paramGroup.Font = new System.Drawing.Font("Tahoma", 8F);
            this.paramGroup.Location = new System.Drawing.Point(0, 0);
            this.paramGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paramGroup.Name = "paramGroup";
            this.paramGroup.Padding = new System.Windows.Forms.Padding(4, 0, 27, 25);
            this.paramGroup.Size = new System.Drawing.Size(466, 58);
            this.paramGroup.TabIndex = 1;
            this.paramGroup.TabStop = false;
            // 
            // DefaultReportParameterInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paramGroup);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DefaultReportParameterInput";
            this.Size = new System.Drawing.Size(466, 58);
            this.paramGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TrafodionComboBox paramCombo;
        private TrafodionGroupBox paramGroup;
        private TrafodionToolTip paramToolTip;
    }
}

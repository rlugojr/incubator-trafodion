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
﻿namespace Trafodion.Manager.MetricMiner.Controls
{
    partial class TextBoxDataDisplayControl
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
            this._theTextBox = new Trafodion.Manager.Framework.Controls.TrafodionRichTextBox();
            this.SuspendLayout();
            // 
            // _theTextBox
            // 
            this._theTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._theTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this._theTextBox.Location = new System.Drawing.Point(0, 0);
            this._theTextBox.Name = "_theTextBox";
            this._theTextBox.Size = new System.Drawing.Size(573, 313);
            this._theTextBox.TabIndex = 0;
            this._theTextBox.Text = "";
            // 
            // TextBoxDataDisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._theTextBox);
            this.Name = "TextBoxDataDisplayControl";
            this.Size = new System.Drawing.Size(573, 313);
            this.ResumeLayout(false);

        }

        #endregion

        private Trafodion.Manager.Framework.Controls.TrafodionRichTextBox _theTextBox;
    }
}

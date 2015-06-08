﻿//
// @@@ START COPYRIGHT @@@
//
// (C) Copyright 2007-2015 Hewlett-Packard Development Company, L.P.
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
//

using System.Drawing;
using System.Windows.Forms;
using Trafodion.Manager.Framework.Controls;

namespace Trafodion.Manager.ConnectivityArea.Controls
{
    /// <summary>
    /// 
    /// </summary>
    public class ConnectivityAreaNDCSMonitorDSStatusSubTabPage : DelayedPopulateClonableTabPage
    {
        private ConnectivityAreaNDCSMonitorDSStatusUserControl theConnectivityAreaNDCSMonitorDSStatusUserControl;

        /// <summary>
        /// 
        /// </summary>
        public ConnectivityAreaNDCSMonitorDSStatusUserControl TheConnectivityAreaNDCSMonitorDSStatusUserControl
        {
            get { return theConnectivityAreaNDCSMonitorDSStatusUserControl; }
            set { theConnectivityAreaNDCSMonitorDSStatusUserControl = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public ConnectivityAreaNDCSMonitorDSStatusSubTabPage(ConnectivityAreaNDCSMonitorDSStatusUserControl theNDCSMonitorDSStatusUserControl)
            : base(Properties.Resources.NDCSDSStatus)
        {
            TheConnectivityAreaNDCSMonitorDSStatusUserControl = theNDCSMonitorDSStatusUserControl;
        }

        public override void PrepareForPopulate()
        {
            if (TheConnectivityAreaNDCSMonitorDSStatusUserControl.NdcsService != null)
            {
                object a = TheConnectivityAreaNDCSMonitorDSStatusUserControl.NdcsService.GetDataSourceStatus();
            }
            else
            {
                object a = TheConnectivityAreaNDCSMonitorDSStatusUserControl.NdcsSystem.GetAllDataSourceStatus();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        protected override void Populate()
        {
            Controls.Clear();
            TheConnectivityAreaNDCSMonitorDSStatusUserControl.Dock = DockStyle.Fill;
            TheConnectivityAreaNDCSMonitorDSStatusUserControl.BackColor = Color.WhiteSmoke;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                TheConnectivityAreaNDCSMonitorDSStatusUserControl.Populate();
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            Controls.Add(TheConnectivityAreaNDCSMonitorDSStatusUserControl);
        }

    }
}

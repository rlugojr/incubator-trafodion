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

using Trafodion.Manager.Framework.Connections;
using Trafodion.Manager.Framework.Navigation;
using Trafodion.Manager.ConnectivityArea.Model;
using Trafodion.Manager.Framework.Controls;
using System;
using System.Windows.Forms;
using Trafodion.Manager.Framework;

namespace Trafodion.Manager.ConnectivityArea.Controls
{

    class ConnectionFolderFactory : NavigationTreeConnectionFolderFactory
    {
        override public NavigationTreeConnectionFolder NewNavigationTreeConnectionFolder(ConnectionDefinition aConnectionDefinition)
        {
            try
            {
                NDCSSystem system = NDCSSystem.FindNDCSSystem(aConnectionDefinition);
                return new Trafodion.Manager.ConnectivityArea.Controls.Tree.ConnectivitySystemFolder(system);
            }
            catch (System.Data.Odbc.OdbcException oe)
            {
                // Got an ODBC erorr. Show it.
                MessageBox.Show(Utilities.GetForegroundControl(), oe.Message, Properties.Resources.ODBCError, MessageBoxButtons.OK);
                return null;
            }
            catch (Exception ex)
            {
                // Got some other exception.  Show it.
                MessageBox.Show(Utilities.GetForegroundControl(), ex.Message, Properties.Resources.SystemError, MessageBoxButtons.OK);
                return null;
            }

        }
        public override NavigationTreeConnectionFolder UpdateNavigationTreeConnectionFolder(ConnectionDefinition aConnectionDefinition, NavigationTreeConnectionFolder connectionTreeFolder)
        {
            try
            {
                NDCSSystem system = NDCSSystem.FindNDCSSystem(aConnectionDefinition);
                return new Trafodion.Manager.ConnectivityArea.Controls.Tree.ConnectivitySystemFolder(system);
            }
            catch (System.Data.Odbc.OdbcException oe)
            {
                // Got an ODBC erorr. Show it.
                MessageBox.Show(Utilities.GetForegroundControl(), oe.Message, Properties.Resources.ODBCError, MessageBoxButtons.OK);
                return null;
            }
            catch (Exception ex)
            {
                // Got some other exception.  Show it.
                MessageBox.Show(Utilities.GetForegroundControl(), ex.Message, Properties.Resources.SystemError, MessageBoxButtons.OK);
                return null;
            }
        }

    }

}

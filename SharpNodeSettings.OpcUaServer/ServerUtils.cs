using Opc.Ua.Server.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpNodeSettings.OpcUaServer
{
    /// <summary>
    /// Defines numerous re-useable utility functions.
    /// </summary>
    public partial class ServerUtils
    {
        /// <summary>
        /// Handles an exception.
        /// </summary>
        public static void HandleException(string caption, Exception e)
        {
            ExceptionDlg.Show(caption, e);
        }

        /// <summary>
        /// Returns the application icon.
        /// </summary>
        public static System.Drawing.Icon GetAppIcon()
        {
            try
            {
                return new Icon("App.ico");
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MediaTypeNames.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            MediaTypeNames.Application.EnableVisualStyles();
            MediaTypeNames.Application.SetCompatibleTextRenderingDefault(false);
            MediaTypeNames.Application.Run(new Form1());
        }
    }
}
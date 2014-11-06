/*
 * Michael Köppl 3AHIF
 * Telefonkosten (C# Windows Forms)
 * 2014/2015
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSTelefonkostenForms
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

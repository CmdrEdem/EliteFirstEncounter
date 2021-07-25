using EliteFirstEncounter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EliteJsonParser;
using EliteExplorer.view.gui;

namespace EliteExplorer
{
    static class EliteFirstEncounter
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("JsonEliteJournalEntry unity test");
            EliteJsonParser.Model.JsonEliteJournalEntry.UnitTest();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}

using EliteFirstEncounter;
using EliteFirstEncounter.view.gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliteExplorer.view.gui
{
    public partial class MainWindow : Form
    {
        private static AboutBoxCustom about;
        public MainWindow()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(MainWindow_DragEnter);
            this.DragDrop += new DragEventHandler(MainWindow_DragDrop);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (about == null)
                about = new();
            about.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsWindow settings = new SettingsWindow();

            settings.FormClosed += SettingsWindow_FormClosed;

            settings.ShowDialog();

        }

        private void SettingsWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                SettingsWindow closedSettings = (SettingsWindow)sender;
                closedSettings.Dispose();
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
                Console.Error.Write(ex.StackTrace);
            }
        }

        void MainWindow_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void MainWindow_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            //TODO: Implement file drop handling
            //foreach (string file in files) Console.WriteLine(file);
        }
    }
}

using EliteFirstEncounter.view.database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliteFirstEncounter.view.gui
{
    public partial class SettingsWindow : Form
    {
        private Dictionary<string, string> loadedSettings;
        public SettingsWindow()
        {
            InitializeComponent();
            textBoxJournalPath.TextChanged += textBoxJournalPath_TextChanged;
            
            loadedSettings = new();

            loadedSettings = Setting.ReadSettings();

            if(loadedSettings.ContainsKey("EliteJournalsPath"))
                textBoxJournalPath.Text = loadedSettings["EliteJournalsPath"];
        }

        public void textBoxJournalPath_TextChanged(object sender, EventArgs e)
        {
            if (loadedSettings.ContainsKey("EliteJournalsPath") && (String.Compare(loadedSettings["EliteJournalsPath"], textBoxJournalPath.Text, StringComparison.Ordinal) == 0))
                textBoxJournalPath.ForeColor = Color.Black;
            else
                textBoxJournalPath.ForeColor = Color.Red;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (loadedSettings.ContainsKey("EliteJournalsPath") && (String.Compare(loadedSettings["EliteJournalsPath"].ToString(), textBoxJournalPath.Text, StringComparison.Ordinal) != 0))
                Setting.WriteSetting("EliteJournalsPath", textBoxJournalPath.Text);

        }
    }
}

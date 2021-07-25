using EliteFirstEncounter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliteExplorer
{
    public partial class MainWindow : Form
    {
        private static AboutBoxCustom about;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            if(about == null)
                about = new();
            about.ShowDialog();
        }
    }
}

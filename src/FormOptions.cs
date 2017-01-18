using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ocean
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        private void buttonBrowse1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Log Files (*.log)|*.log|All Files (*.*)|*.*";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            textCommandLogLocation.Text = dialog.FileName;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Log_Command = textCommandLogLocation.Text;
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(Properties.Settings.Default.Log_Command)) {
                textCommandLogLocation.Text = Properties.Settings.Default.Log_Command;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/dantheman213/ocean-sql-profiler/blob/master/README.md");
            Process.Start(sInfo);
        }
    }
}

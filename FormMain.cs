using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ocean
{
    public partial class FormMain : Form
    {
        private static String logFile = null;
        private static long lastLogSize = 0;
        private static int lastLinePos = 0;
        private static bool firstRun = true;

        public FormMain()
        {
            InitializeComponent();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOptions form = new FormOptions();
            form.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(Properties.Settings.Default.Log_Command)) {
                logFile = Properties.Settings.Default.Log_Command;

                listLogItems.Items.Clear();

                watcher.Interval = 1000;
                watcher.Start();

                toolStripStart.Enabled = false;
                toolStripStop.Enabled = true;
            } else {
                MessageBox.Show("Command log has not been set yet! Check options.");
            }
        }

        private void toolStripStop_Click(object sender, EventArgs e)
        {
            watcher.Stop();

            toolStripStop.Enabled = false;
            toolStripStart.Enabled = true;
        }

        private void watcher_Tick(object sender, EventArgs e)
        {
            FileInfo info = new FileInfo(logFile);
            if (lastLogSize < info.Length) {
                lastLogSize = info.Length;

                FileStream stream = File.Open(logFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader reader = new StreamReader(stream);

                string currentLine = null;
                int currentLinePos = 0;

                while ((currentLine = reader.ReadLine()) != null) {
                    if (currentLinePos > lastLinePos) {
                        lastLinePos = currentLinePos;

                        if(!String.IsNullOrEmpty(currentLine)) {
                            List<string> items = currentLine.Split(' ').ToList();
        
                            if(items.Count > 4) {
                                string timestamp = items[0] + ' ' + items[1] + ' ' + items[2];
                                string type = items[3];

                                items.RemoveAt(3);
                                items.RemoveAt(2);
                                items.RemoveAt(1);
                                items.RemoveAt(0);

                                string command = String.Join(" ", items.ToArray());

                                string[] row = { timestamp, type, command };

                                if(!firstRun) {
                                    listLogItems.Items.Add(new ListViewItem(row));
                                }
                            }
                        }
                    }

                    currentLinePos++;
                }

                reader.Close();
                stream.Close();
                autoResizeColumns(listLogItems);
                firstRun = false;
            }
        }

        public static void autoResizeColumns(ListView lv)
        {
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ListView.ColumnHeaderCollection cc = lv.Columns;
            for (int i = 0; i < cc.Count; i++) {
                int colWidth = TextRenderer.MeasureText(cc[i].Text, lv.Font).Width + 10;
                if (colWidth > cc[i].Width) {
                    cc[i].Width = colWidth;
                }
            }
        }
        
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listLogItems.Items.Clear();
        }
        

        private void listLogItems_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                contextMenuLogs.Show(Cursor.Position);
            }
        }
        

        private void FormMain_Load(object sender, EventArgs e)
        {
            autoResizeColumns(listLogItems);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.Show();
        }

        private void copyValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listLogItems.SelectedItems.Count > 0) {
                var item = listLogItems.SelectedItems[0];
                Clipboard.SetText(item.SubItems[2].Text);
            } else {
                MessageBox.Show("Select a row first!");
            }
        }
    }
}

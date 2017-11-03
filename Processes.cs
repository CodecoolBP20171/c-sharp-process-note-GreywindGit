using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace processnote
{
    public partial class Processes : Form
    {
        private Dictionary<int, string> commentList = new Dictionary<int, string>();
        private int actualPID = -1;

        public Processes()
        {
            InitializeComponent();
        }

        private void Processes_Load(object sender, EventArgs e)
        {
            SetupHeader();
            PopulateData();
        }

        private void SetupHeader()
        {
            processList.ColumnCount = 5;
            processList.EnableHeadersVisualStyles = false;
            processList.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
            processList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            processList.Columns[0].Name = "Process";
            processList.Columns[1].Name = "PID";
            processList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            processList.Columns[2].Name = "Memory usage";
            processList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            processList.Columns[3].Name = "CPU time";
            processList.Columns[4].Name = "Start time";
        }

        private void PopulateData()
        {
            Process[] runningProcesses = Process.GetProcesses();
            string cpuTime;
            string startTime;

            foreach (Process process in runningProcesses)
            {
                try
                {
                    cpuTime = process.TotalProcessorTime.ToString();
                    startTime = process.StartTime.ToString();
                }
                catch (Exception)
                {
                    cpuTime = "N/A";
                    startTime = "N/A";
                }

                string[] newData =
                {
                    process.ProcessName,
                    process.Id.ToString(),
                    (process.WorkingSet64 / 1024).ToString() + " kB",
                    cpuTime,
                    startTime
                };
                processList.Rows.Add(newData);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            processList.Rows.Clear();
            PopulateData();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProcessList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            processDetails.Clear(); 
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = processList.Rows[rowIndex];
            foreach (DataGridViewCell cell in selectedRow.Cells)
            {
                processDetails.AppendText($"{processList.Columns[cell.ColumnIndex].Name}: {cell.Value.ToString()} \n");
            }
            int.TryParse(selectedRow.Cells[1].Value.ToString(), out actualPID);
            commentBox.Text = commentList.Keys.Contains(actualPID) ? commentList[actualPID] : "";
            commentBox.Focus();
            commentBox.SelectionStart = commentBox.Text.Length;
            saveComment.BackColor = Control.DefaultBackColor;
        }

        private void ProcessList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    int rowIndex = e.RowIndex;
                    if (rowIndex >= 0)
                    {
                        DataGridViewCell pidCell = processList.Rows[rowIndex].Cells[1];
                        int.TryParse(pidCell.Value.ToString(), out int processId);
                    }

                    ContextMenuStrip cms = new ContextMenuStrip();
                    cms.Items.Add("Kill Process");
                    cms.Items.Add("Cancel");

                    try
                    {
                        processList.Rows[rowIndex].Cells[e.ColumnIndex].ContextMenuStrip = cms;
                    }
                    catch (Exception)
                    {
                    }
                    break;
                default:
                    break;
            }
        }

        private void CommentBox_TextChanged(object sender, EventArgs e)
        {
            if (actualPID > -1)
            {
                saveComment.BackColor = Color.IndianRed;
                saveComment.Text = "Save comment";
            }
        }

        private void SaveComment_Click(object sender, EventArgs e)
        {
            SaveComment();
        }

        private void CommentBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                SaveComment();
            }
        }

        private void SaveComment()
        {
            if (actualPID > -1)
            {
                commentList[actualPID] = commentBox.Text;
                saveComment.BackColor = Color.LawnGreen;
                saveComment.Text = "Comment saved";

            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }
    }
}

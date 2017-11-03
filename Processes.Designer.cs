namespace processnote
{
    partial class Processes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Processes));
            this.processList = new System.Windows.Forms.DataGridView();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.processCommentsLabel = new System.Windows.Forms.Label();
            this.processDetailsLabel = new System.Windows.Forms.Label();
            this.saveComment = new System.Windows.Forms.Button();
            this.commentBox = new System.Windows.Forms.RichTextBox();
            this.processDetails = new System.Windows.Forms.RichTextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.processList)).BeginInit();
            this.detailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // processList
            // 
            this.processList.AllowUserToAddRows = false;
            this.processList.AllowUserToDeleteRows = false;
            this.processList.AllowUserToResizeColumns = false;
            this.processList.AllowUserToResizeRows = false;
            this.processList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.processList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.processList.Location = new System.Drawing.Point(21, 46);
            this.processList.Name = "processList";
            this.processList.RowHeadersVisible = false;
            this.processList.RowTemplate.Height = 24;
            this.processList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.processList.Size = new System.Drawing.Size(864, 466);
            this.processList.TabIndex = 1;
            this.processList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProcessList_CellMouseClick);
            this.processList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProcessList_RowHeaderMouseDoubleClick);
            // 
            // detailPanel
            // 
            this.detailPanel.Controls.Add(this.processCommentsLabel);
            this.detailPanel.Controls.Add(this.processDetailsLabel);
            this.detailPanel.Controls.Add(this.saveComment);
            this.detailPanel.Controls.Add(this.commentBox);
            this.detailPanel.Controls.Add(this.processDetails);
            this.detailPanel.Location = new System.Drawing.Point(21, 527);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(864, 201);
            this.detailPanel.TabIndex = 2;
            // 
            // processCommentsLabel
            // 
            this.processCommentsLabel.AutoSize = true;
            this.processCommentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processCommentsLabel.Location = new System.Drawing.Point(412, 0);
            this.processCommentsLabel.Name = "processCommentsLabel";
            this.processCommentsLabel.Size = new System.Drawing.Size(74, 17);
            this.processCommentsLabel.TabIndex = 7;
            this.processCommentsLabel.Text = "Comments";
            // 
            // processDetailsLabel
            // 
            this.processDetailsLabel.AutoSize = true;
            this.processDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processDetailsLabel.Location = new System.Drawing.Point(-3, 2);
            this.processDetailsLabel.Name = "processDetailsLabel";
            this.processDetailsLabel.Size = new System.Drawing.Size(106, 17);
            this.processDetailsLabel.TabIndex = 6;
            this.processDetailsLabel.Text = "Process Details";
            // 
            // saveComment
            // 
            this.saveComment.Location = new System.Drawing.Point(539, 145);
            this.saveComment.Name = "saveComment";
            this.saveComment.Size = new System.Drawing.Size(186, 35);
            this.saveComment.TabIndex = 5;
            this.saveComment.Text = "Save Comment";
            this.saveComment.UseVisualStyleBackColor = true;
            this.saveComment.Click += new System.EventHandler(this.SaveComment_Click);
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(412, 22);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(452, 108);
            this.commentBox.TabIndex = 1;
            this.commentBox.Text = "";
            this.commentBox.TextChanged += new System.EventHandler(this.CommentBox_TextChanged);
            this.commentBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommentBox_KeyDown);
            // 
            // processDetails
            // 
            this.processDetails.Location = new System.Drawing.Point(0, 22);
            this.processDetails.Name = "processDetails";
            this.processDetails.ReadOnly = true;
            this.processDetails.Size = new System.Drawing.Size(389, 108);
            this.processDetails.TabIndex = 0;
            this.processDetails.Text = "";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(21, 755);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(189, 36);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(699, 755);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(186, 36);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(760, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Always On Top";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Processes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 803);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.detailPanel);
            this.Controls.Add(this.processList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Processes";
            this.Text = "Processes";
            this.Load += new System.EventHandler(this.Processes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processList)).EndInit();
            this.detailPanel.ResumeLayout(false);
            this.detailPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView processList;
        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.RichTextBox commentBox;
        private System.Windows.Forms.RichTextBox processDetails;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveComment;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label processCommentsLabel;
        private System.Windows.Forms.Label processDetailsLabel;
    }
}
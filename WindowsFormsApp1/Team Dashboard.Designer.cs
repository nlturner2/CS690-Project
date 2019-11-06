namespace WindowsFormsApp1
{
    partial class Team_Dashboard
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
            this.TeadDashboard = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.Notes = new System.Windows.Forms.TabPage();
            this.GithubHistory = new System.Windows.Forms.TabPage();
            this.Members = new System.Windows.Forms.TabPage();
            this.Summary = new System.Windows.Forms.TabPage();
            this.TabBox = new System.Windows.Forms.TabControl();
            this.TeamMeeting = new System.Windows.Forms.TabPage();
            this.WeeklyProgress = new System.Windows.Forms.TabPage();
            this.summaryrichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Summary.SuspendLayout();
            this.TabBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeadDashboard
            // 
            this.TeadDashboard.AutoSize = true;
            this.TeadDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeadDashboard.Location = new System.Drawing.Point(8, 9);
            this.TeadDashboard.Name = "TeadDashboard";
            this.TeadDashboard.Size = new System.Drawing.Size(146, 20);
            this.TeadDashboard.TabIndex = 4;
            this.TeadDashboard.Text = "Team Dashboard";
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(816, 9);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 46);
            this.Home.TabIndex = 7;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.button1_Click);
            // 
            // Notes
            // 
            this.Notes.Location = new System.Drawing.Point(4, 22);
            this.Notes.Name = "Notes";
            this.Notes.Padding = new System.Windows.Forms.Padding(3);
            this.Notes.Size = new System.Drawing.Size(875, 462);
            this.Notes.TabIndex = 3;
            this.Notes.Text = "Notes";
            this.Notes.UseVisualStyleBackColor = true;
            // 
            // GithubHistory
            // 
            this.GithubHistory.Location = new System.Drawing.Point(4, 22);
            this.GithubHistory.Name = "GithubHistory";
            this.GithubHistory.Size = new System.Drawing.Size(875, 462);
            this.GithubHistory.TabIndex = 2;
            this.GithubHistory.Text = "Github History";
            this.GithubHistory.UseVisualStyleBackColor = true;
            // 
            // Members
            // 
            this.Members.Location = new System.Drawing.Point(4, 22);
            this.Members.Name = "Members";
            this.Members.Padding = new System.Windows.Forms.Padding(3);
            this.Members.Size = new System.Drawing.Size(875, 462);
            this.Members.TabIndex = 1;
            this.Members.Text = "Members";
            this.Members.UseVisualStyleBackColor = true;
            // 
            // Summary
            // 
            this.Summary.Controls.Add(this.summaryrichTextBox1);
            this.Summary.Location = new System.Drawing.Point(4, 22);
            this.Summary.Name = "Summary";
            this.Summary.Padding = new System.Windows.Forms.Padding(3);
            this.Summary.Size = new System.Drawing.Size(875, 462);
            this.Summary.TabIndex = 0;
            this.Summary.Text = "Summary";
            this.Summary.UseVisualStyleBackColor = true;
            this.Summary.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // TabBox
            // 
            this.TabBox.Controls.Add(this.Summary);
            this.TabBox.Controls.Add(this.Members);
            this.TabBox.Controls.Add(this.GithubHistory);
            this.TabBox.Controls.Add(this.TeamMeeting);
            this.TabBox.Controls.Add(this.WeeklyProgress);
            this.TabBox.Controls.Add(this.Notes);
            this.TabBox.Location = new System.Drawing.Point(12, 61);
            this.TabBox.Name = "TabBox";
            this.TabBox.SelectedIndex = 0;
            this.TabBox.Size = new System.Drawing.Size(883, 488);
            this.TabBox.TabIndex = 8;
            // 
            // TeamMeeting
            // 
            this.TeamMeeting.Location = new System.Drawing.Point(4, 22);
            this.TeamMeeting.Name = "TeamMeeting";
            this.TeamMeeting.Size = new System.Drawing.Size(875, 462);
            this.TeamMeeting.TabIndex = 4;
            this.TeamMeeting.Text = "Team Meeting";
            this.TeamMeeting.UseVisualStyleBackColor = true;
            // 
            // WeeklyProgress
            // 
            this.WeeklyProgress.Location = new System.Drawing.Point(4, 22);
            this.WeeklyProgress.Name = "WeeklyProgress";
            this.WeeklyProgress.Size = new System.Drawing.Size(875, 462);
            this.WeeklyProgress.TabIndex = 5;
            this.WeeklyProgress.Text = "Weekly Progress";
            this.WeeklyProgress.UseVisualStyleBackColor = true;
            // 
            // summaryrichTextBox1
            // 
            this.summaryrichTextBox1.Location = new System.Drawing.Point(17, 16);
            this.summaryrichTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.summaryrichTextBox1.Name = "summaryrichTextBox1";
            this.summaryrichTextBox1.Size = new System.Drawing.Size(835, 425);
            this.summaryrichTextBox1.TabIndex = 0;
            this.summaryrichTextBox1.Text = "";
            this.summaryrichTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Team_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 561);
            this.Controls.Add(this.TabBox);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.TeadDashboard);
            this.Name = "Team_Dashboard";
            this.Text = "Team_Dashboard";
            this.Load += new System.EventHandler(this.Team_Dashboard_Load);
            this.Summary.ResumeLayout(false);
            this.TabBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TeadDashboard;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.TabPage Notes;
        private System.Windows.Forms.TabPage GithubHistory;
        private System.Windows.Forms.TabPage Members;
        private System.Windows.Forms.TabPage Summary;
        private System.Windows.Forms.TabControl TabBox;
        private System.Windows.Forms.TabPage TeamMeeting;
        private System.Windows.Forms.TabPage WeeklyProgress;
        public System.Windows.Forms.RichTextBox summaryrichTextBox1;
    }
}
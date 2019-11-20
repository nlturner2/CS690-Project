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
            this.WeeklyProgress = new System.Windows.Forms.TabPage();
            this.Progress_List = new System.Windows.Forms.ListBox();
            this.TeamMeeting = new System.Windows.Forms.TabPage();
            this.filesBox = new System.Windows.Forms.ListBox();
            this.meetingRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Members = new System.Windows.Forms.TabPage();
            this.teamMembersRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Summary = new System.Windows.Forms.TabPage();
            this.summaryrichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TextBox = new System.Windows.Forms.TabControl();
            this.Notification_Table2 = new System.Windows.Forms.TableLayoutPanel();
            this.WeeklyProgress.SuspendLayout();
            this.TeamMeeting.SuspendLayout();
            this.Members.SuspendLayout();
            this.Summary.SuspendLayout();
            this.TextBox.SuspendLayout();
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
            this.Home.Click += new System.EventHandler(this.Home_Click);
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
            // WeeklyProgress
            // 
            this.WeeklyProgress.Controls.Add(this.Progress_List);
            this.WeeklyProgress.Location = new System.Drawing.Point(4, 22);
            this.WeeklyProgress.Name = "WeeklyProgress";
            this.WeeklyProgress.Size = new System.Drawing.Size(875, 462);
            this.WeeklyProgress.TabIndex = 5;
            this.WeeklyProgress.Text = "Weekly Progress";
            this.WeeklyProgress.UseVisualStyleBackColor = true;
            // 
            // Progress_List
            // 
            this.Progress_List.FormattingEnabled = true;
            this.Progress_List.Location = new System.Drawing.Point(8, 11);
            this.Progress_List.Margin = new System.Windows.Forms.Padding(2);
            this.Progress_List.Name = "Progress_List";
            this.Progress_List.ScrollAlwaysVisible = true;
            this.Progress_List.Size = new System.Drawing.Size(861, 446);
            this.Progress_List.TabIndex = 0;
            this.Progress_List.SelectedIndexChanged += new System.EventHandler(this.Progress_List_SelectedIndexChanged);
            // 
            // TeamMeeting
            // 
            this.TeamMeeting.Controls.Add(this.filesBox);
            this.TeamMeeting.Controls.Add(this.meetingRichTextBox1);
            this.TeamMeeting.Location = new System.Drawing.Point(4, 22);
            this.TeamMeeting.Name = "TeamMeeting";
            this.TeamMeeting.Size = new System.Drawing.Size(875, 462);
            this.TeamMeeting.TabIndex = 4;
            this.TeamMeeting.Text = "Team Meeting";
            this.TeamMeeting.UseVisualStyleBackColor = true;
            this.TeamMeeting.Click += new System.EventHandler(this.TeamMeeting_Click);
            // 
            // filesBox
            // 
            this.filesBox.FormattingEnabled = true;
            this.filesBox.Location = new System.Drawing.Point(679, 16);
            this.filesBox.Name = "filesBox";
            this.filesBox.Size = new System.Drawing.Size(183, 121);
            this.filesBox.TabIndex = 1;
            this.filesBox.SelectedIndexChanged += new System.EventHandler(this.filesBox_SelectedIndexChanged);
            // 
            // meetingRichTextBox1
            // 
            this.meetingRichTextBox1.Location = new System.Drawing.Point(0, 2);
            this.meetingRichTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.meetingRichTextBox1.Name = "meetingRichTextBox1";
            this.meetingRichTextBox1.Size = new System.Drawing.Size(873, 464);
            this.meetingRichTextBox1.TabIndex = 0;
            this.meetingRichTextBox1.Text = "";
            this.meetingRichTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_2);
            // 
            // Members
            // 
            this.Members.Controls.Add(this.Notification_Table2);
            this.Members.Controls.Add(this.teamMembersRichTextBox1);
            this.Members.Location = new System.Drawing.Point(4, 22);
            this.Members.Name = "Members";
            this.Members.Padding = new System.Windows.Forms.Padding(3);
            this.Members.Size = new System.Drawing.Size(875, 462);
            this.Members.TabIndex = 1;
            this.Members.Text = "Members";
            this.Members.UseVisualStyleBackColor = true;
            // 
            // teamMembersRichTextBox1
            // 
            this.teamMembersRichTextBox1.Location = new System.Drawing.Point(6, 7);
            this.teamMembersRichTextBox1.Name = "teamMembersRichTextBox1";
            this.teamMembersRichTextBox1.Size = new System.Drawing.Size(863, 450);
            this.teamMembersRichTextBox1.TabIndex = 0;
            this.teamMembersRichTextBox1.Text = "";
            this.teamMembersRichTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
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
            // TextBox
            // 
            this.TextBox.Controls.Add(this.Summary);
            this.TextBox.Controls.Add(this.Members);
            this.TextBox.Controls.Add(this.TeamMeeting);
            this.TextBox.Controls.Add(this.WeeklyProgress);
            this.TextBox.Controls.Add(this.Notes);
            this.TextBox.Location = new System.Drawing.Point(12, 61);
            this.TextBox.Name = "TextBox";
            this.TextBox.SelectedIndex = 0;
            this.TextBox.Size = new System.Drawing.Size(883, 488);
            this.TextBox.TabIndex = 8;
            // 
            // Notification_Table2
            // 
            this.Notification_Table2.AutoScroll = true;
            this.Notification_Table2.ColumnCount = 1;
            this.Notification_Table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Notification_Table2.Location = new System.Drawing.Point(587, 7);
            this.Notification_Table2.Name = "Notification_Table2";
            this.Notification_Table2.RowCount = 30;
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table2.Size = new System.Drawing.Size(282, 449);
            this.Notification_Table2.TabIndex = 1;
            // 
            // Team_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(908, 456);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.TeadDashboard);
            this.Name = "Team_Dashboard";
            this.Text = "Team_Dashboard";
            this.Load += new System.EventHandler(this.Team_Dashboard_Load);
            this.WeeklyProgress.ResumeLayout(false);
            this.TeamMeeting.ResumeLayout(false);
            this.Members.ResumeLayout(false);
            this.Summary.ResumeLayout(false);
            this.TextBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TeadDashboard;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.TabPage Notes;
        private System.Windows.Forms.TabPage WeeklyProgress;
        private System.Windows.Forms.TabPage TeamMeeting;
        public System.Windows.Forms.RichTextBox meetingRichTextBox1;
        private System.Windows.Forms.TabPage Members;
        public System.Windows.Forms.RichTextBox teamMembersRichTextBox1;
        private System.Windows.Forms.TabPage Summary;
        public System.Windows.Forms.RichTextBox summaryrichTextBox1;
        public System.Windows.Forms.TabControl TextBox;
        public System.Windows.Forms.ListBox Progress_List;
        public System.Windows.Forms.TableLayoutPanel Notification_Table2;
        public System.Windows.Forms.ListBox filesBox;
    }
}
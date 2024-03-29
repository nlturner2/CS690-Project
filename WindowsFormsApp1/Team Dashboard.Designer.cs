﻿namespace WindowsFormsApp1
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
            this.NotesRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveNotes = new System.Windows.Forms.Button();
            this.WeeklyProgress = new System.Windows.Forms.TabPage();
            this.Progress_List = new System.Windows.Forms.ListBox();
            this.TeamMeeting = new System.Windows.Forms.TabPage();
            this.filesBox = new System.Windows.Forms.ListBox();
            this.meetingRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Members = new System.Windows.Forms.TabPage();
            this.Notification_Table2 = new System.Windows.Forms.TableLayoutPanel();
            this.teamMembersRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Summary = new System.Windows.Forms.TabPage();
            this.summaryrichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TextBox = new System.Windows.Forms.TabControl();
            this.Notes.SuspendLayout();
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
            this.TeadDashboard.Location = new System.Drawing.Point(12, 14);
            this.TeadDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TeadDashboard.Name = "TeadDashboard";
            this.TeadDashboard.Size = new System.Drawing.Size(214, 29);
            this.TeadDashboard.TabIndex = 4;
            this.TeadDashboard.Text = "Team Dashboard";
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(1220, 14);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(112, 71);
            this.Home.TabIndex = 7;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Notes
            // 
            this.Notes.Controls.Add(this.NotesRichTextBox1);
            this.Notes.Controls.Add(this.saveNotes);
            this.Notes.Location = new System.Drawing.Point(4, 29);
            this.Notes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Notes.Name = "Notes";
            this.Notes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Notes.Size = new System.Drawing.Size(1316, 575);
            this.Notes.TabIndex = 3;
            this.Notes.Text = "Notes";
            this.Notes.UseVisualStyleBackColor = true;
            // 
            // NotesRichTextBox1
            // 
            this.NotesRichTextBox1.Location = new System.Drawing.Point(0, 0);
            this.NotesRichTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NotesRichTextBox1.Name = "NotesRichTextBox1";
            this.NotesRichTextBox1.Size = new System.Drawing.Size(1184, 561);
            this.NotesRichTextBox1.TabIndex = 2;
            this.NotesRichTextBox1.Text = "";
            // 
            // saveNotes
            // 
            this.saveNotes.Location = new System.Drawing.Point(1196, 9);
            this.saveNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveNotes.Name = "saveNotes";
            this.saveNotes.Size = new System.Drawing.Size(112, 46);
            this.saveNotes.TabIndex = 1;
            this.saveNotes.Text = "Save";
            this.saveNotes.UseVisualStyleBackColor = true;
            this.saveNotes.Click += new System.EventHandler(this.SaveNotes_Click);
            // 
            // WeeklyProgress
            // 
            this.WeeklyProgress.Controls.Add(this.Progress_List);
            this.WeeklyProgress.Location = new System.Drawing.Point(4, 29);
            this.WeeklyProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WeeklyProgress.Name = "WeeklyProgress";
            this.WeeklyProgress.Size = new System.Drawing.Size(1316, 575);
            this.WeeklyProgress.TabIndex = 5;
            this.WeeklyProgress.Text = "Weekly Progress";
            this.WeeklyProgress.UseVisualStyleBackColor = true;
            // 
            // Progress_List
            // 
            this.Progress_List.FormattingEnabled = true;
            this.Progress_List.ItemHeight = 20;
            this.Progress_List.Location = new System.Drawing.Point(12, 17);
            this.Progress_List.Name = "Progress_List";
            this.Progress_List.ScrollAlwaysVisible = true;
            this.Progress_List.Size = new System.Drawing.Size(1290, 544);
            this.Progress_List.TabIndex = 0;
            this.Progress_List.SelectedIndexChanged += new System.EventHandler(this.Progress_List_SelectedIndexChanged);
            // 
            // TeamMeeting
            // 
            this.TeamMeeting.Controls.Add(this.filesBox);
            this.TeamMeeting.Controls.Add(this.meetingRichTextBox1);
            this.TeamMeeting.Location = new System.Drawing.Point(4, 29);
            this.TeamMeeting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TeamMeeting.Name = "TeamMeeting";
            this.TeamMeeting.Size = new System.Drawing.Size(1316, 575);
            this.TeamMeeting.TabIndex = 4;
            this.TeamMeeting.Text = "Team Meeting";
            this.TeamMeeting.UseVisualStyleBackColor = true;
            this.TeamMeeting.Click += new System.EventHandler(this.TeamMeeting_Click);
            // 
            // filesBox
            // 
            this.filesBox.FormattingEnabled = true;
            this.filesBox.ItemHeight = 20;
            this.filesBox.Location = new System.Drawing.Point(974, 22);
            this.filesBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filesBox.Name = "filesBox";
            this.filesBox.Size = new System.Drawing.Size(272, 184);
            this.filesBox.TabIndex = 1;
            this.filesBox.SelectedIndexChanged += new System.EventHandler(this.filesBox_SelectedIndexChanged);
            // 
            // meetingRichTextBox1
            // 
            this.meetingRichTextBox1.Location = new System.Drawing.Point(0, 3);
            this.meetingRichTextBox1.Name = "meetingRichTextBox1";
            this.meetingRichTextBox1.Size = new System.Drawing.Size(1308, 712);
            this.meetingRichTextBox1.TabIndex = 0;
            this.meetingRichTextBox1.Text = "";
            this.meetingRichTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_2);
            // 
            // Members
            // 
            this.Members.Controls.Add(this.Notification_Table2);
            this.Members.Controls.Add(this.teamMembersRichTextBox1);
            this.Members.Location = new System.Drawing.Point(4, 29);
            this.Members.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Members.Name = "Members";
            this.Members.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Members.Size = new System.Drawing.Size(1316, 575);
            this.Members.TabIndex = 1;
            this.Members.Text = "Members";
            this.Members.UseVisualStyleBackColor = true;
            // 
            // Notification_Table2
            // 
            this.Notification_Table2.AutoScroll = true;
            this.Notification_Table2.ColumnCount = 1;
            this.Notification_Table2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Notification_Table2.Location = new System.Drawing.Point(880, 11);
            this.Notification_Table2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Notification_Table2.Name = "Notification_Table2";
            this.Notification_Table2.RowCount = 30;
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.Notification_Table2.Size = new System.Drawing.Size(423, 691);
            this.Notification_Table2.TabIndex = 1;
            // 
            // teamMembersRichTextBox1
            // 
            this.teamMembersRichTextBox1.Location = new System.Drawing.Point(9, 11);
            this.teamMembersRichTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teamMembersRichTextBox1.Name = "teamMembersRichTextBox1";
            this.teamMembersRichTextBox1.Size = new System.Drawing.Size(1292, 690);
            this.teamMembersRichTextBox1.TabIndex = 0;
            this.teamMembersRichTextBox1.Text = "";
            this.teamMembersRichTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Summary
            // 
            this.Summary.Controls.Add(this.summaryrichTextBox1);
            this.Summary.Location = new System.Drawing.Point(4, 29);
            this.Summary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Summary.Name = "Summary";
            this.Summary.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Summary.Size = new System.Drawing.Size(1316, 575);
            this.Summary.TabIndex = 0;
            this.Summary.Text = "Summary";
            this.Summary.UseVisualStyleBackColor = true;
            this.Summary.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // summaryrichTextBox1
            // 
            this.summaryrichTextBox1.Location = new System.Drawing.Point(26, 25);
            this.summaryrichTextBox1.Name = "summaryrichTextBox1";
            this.summaryrichTextBox1.Size = new System.Drawing.Size(1250, 533);
            this.summaryrichTextBox1.TabIndex = 0;
            this.summaryrichTextBox1.Text = "";
            this.summaryrichTextBox1.VScroll += new System.EventHandler(this.summaryrichTextBox1_VScroll);
            this.summaryrichTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // TextBox
            // 
            this.TextBox.Controls.Add(this.Summary);
            this.TextBox.Controls.Add(this.Members);
            this.TextBox.Controls.Add(this.TeamMeeting);
            this.TextBox.Controls.Add(this.WeeklyProgress);
            this.TextBox.Controls.Add(this.Notes);
            this.TextBox.Location = new System.Drawing.Point(18, 94);
            this.TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox.Name = "TextBox";
            this.TextBox.SelectedIndex = 0;
            this.TextBox.Size = new System.Drawing.Size(1324, 608);
            this.TextBox.TabIndex = 8;
            // 
            // Team_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1362, 715);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.TeadDashboard);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Team_Dashboard";
            this.Text = "Team_Dashboard";
            this.Load += new System.EventHandler(this.Team_Dashboard_Load);
            this.Notes.ResumeLayout(false);
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
        private System.Windows.Forms.Button saveNotes;
        public System.Windows.Forms.RichTextBox NotesRichTextBox1;
    }
}
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
            this.button1 = new System.Windows.Forms.Button();
            this.Weekly_Progress = new System.Windows.Forms.Button();
            this.Notes = new System.Windows.Forms.Button();
            this.Github_History = new System.Windows.Forms.Button();
            this.TeadDashboard = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Team_Members = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Weekly_Progress
            // 
            this.Weekly_Progress.Location = new System.Drawing.Point(713, 236);
            this.Weekly_Progress.Name = "Weekly_Progress";
            this.Weekly_Progress.Size = new System.Drawing.Size(75, 46);
            this.Weekly_Progress.TabIndex = 1;
            this.Weekly_Progress.Text = "Weekly Progress";
            this.Weekly_Progress.UseVisualStyleBackColor = true;
            // 
            // Notes
            // 
            this.Notes.Location = new System.Drawing.Point(713, 392);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(75, 46);
            this.Notes.TabIndex = 2;
            this.Notes.Text = "Notes";
            this.Notes.UseVisualStyleBackColor = true;
            // 
            // Github_History
            // 
            this.Github_History.Location = new System.Drawing.Point(713, 288);
            this.Github_History.Name = "Github_History";
            this.Github_History.Size = new System.Drawing.Size(75, 46);
            this.Github_History.TabIndex = 3;
            this.Github_History.Text = "Github History";
            this.Github_History.UseVisualStyleBackColor = true;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 343);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(695, 95);
            this.listBox1.TabIndex = 5;
            // 
            // Team_Members
            // 
            this.Team_Members.AutoSize = true;
            this.Team_Members.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team_Members.Location = new System.Drawing.Point(13, 321);
            this.Team_Members.Name = "Team_Members";
            this.Team_Members.Size = new System.Drawing.Size(131, 20);
            this.Team_Members.TabIndex = 6;
            this.Team_Members.Text = "Team Members";
            // 
            // Team_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Team_Members);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TeadDashboard);
            this.Controls.Add(this.Github_History);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.Weekly_Progress);
            this.Controls.Add(this.button1);
            this.Name = "Team_Dashboard";
            this.Text = "Team_Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Weekly_Progress;
        private System.Windows.Forms.Button Notes;
        private System.Windows.Forms.Button Github_History;
        private System.Windows.Forms.Label TeadDashboard;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Team_Members;
    }
}
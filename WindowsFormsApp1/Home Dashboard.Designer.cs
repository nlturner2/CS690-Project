﻿namespace WindowsFormsApp1
{
    partial class HomeDashboard
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
            this.Add_Team = new System.Windows.Forms.Button();
            this.Remove_Team = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Notifications = new System.Windows.Forms.Label();
            this.Home_Dashboard = new System.Windows.Forms.Label();
            this.Team_List = new System.Windows.Forms.ListBox();
            this.Notifications_List = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Add_Team
            // 
            this.Add_Team.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Add_Team.Location = new System.Drawing.Point(976, 12);
            this.Add_Team.Name = "Add_Team";
            this.Add_Team.Size = new System.Drawing.Size(75, 65);
            this.Add_Team.TabIndex = 0;
            this.Add_Team.Text = "Add Team";
            this.Add_Team.UseVisualStyleBackColor = true;
            this.Add_Team.Click += new System.EventHandler(this.button3_Click);
            // 
            // Remove_Team
            // 
            this.Remove_Team.Location = new System.Drawing.Point(1058, 12);
            this.Remove_Team.Name = "Remove_Team";
            this.Remove_Team.Size = new System.Drawing.Size(98, 65);
            this.Remove_Team.TabIndex = 1;
            this.Remove_Team.Text = "Remove Team";
            this.Remove_Team.UseVisualStyleBackColor = true;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(884, 12);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(86, 65);
            this.Refresh.TabIndex = 2;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(1539, 9);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(82, 66);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.button1_Click);
            // 
            // Notifications
            // 
            this.Notifications.AutoSize = true;
            this.Notifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notifications.Location = new System.Drawing.Point(1156, 28);
            this.Notifications.Name = "Notifications";
            this.Notifications.Size = new System.Drawing.Size(158, 29);
            this.Notifications.TabIndex = 4;
            this.Notifications.Text = "Notifications";
            this.Notifications.Click += new System.EventHandler(this.label1_Click);
            // 
            // Home_Dashboard
            // 
            this.Home_Dashboard.AutoSize = true;
            this.Home_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_Dashboard.Location = new System.Drawing.Point(24, 28);
            this.Home_Dashboard.Name = "Home_Dashboard";
            this.Home_Dashboard.Size = new System.Drawing.Size(216, 29);
            this.Home_Dashboard.TabIndex = 5;
            this.Home_Dashboard.Text = "Home Dashboard";
            this.Home_Dashboard.Click += new System.EventHandler(this.Team_Dashboard_Click);
            // 
            // Team_List
            // 
            this.Team_List.FormattingEnabled = true;
            this.Team_List.ItemHeight = 20;
            this.Team_List.Location = new System.Drawing.Point(28, 82);
            this.Team_List.Name = "Team_List";
            this.Team_List.ScrollAlwaysVisible = true;
            this.Team_List.Size = new System.Drawing.Size(1126, 1004);
            this.Team_List.TabIndex = 6;
            this.Team_List.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Notifications_List
            // 
            this.Notifications_List.FormattingEnabled = true;
            this.Notifications_List.ItemHeight = 20;
            this.Notifications_List.Location = new System.Drawing.Point(1161, 82);
            this.Notifications_List.Name = "Notifications_List";
            this.Notifications_List.ScrollAlwaysVisible = true;
            this.Notifications_List.Size = new System.Drawing.Size(472, 1004);
            this.Notifications_List.TabIndex = 7;
            // 
            // HomeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 1062);
            this.Controls.Add(this.Notifications_List);
            this.Controls.Add(this.Team_List);
            this.Controls.Add(this.Home_Dashboard);
            this.Controls.Add(this.Notifications);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Remove_Team);
            this.Controls.Add(this.Add_Team);
            this.Name = "HomeDashboard";
            this.Text = "Home Dashboard";
            this.Load += new System.EventHandler(this.TeamDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Team;
        private System.Windows.Forms.Button Remove_Team;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Label Notifications;
        private System.Windows.Forms.Label Home_Dashboard;
        private System.Windows.Forms.ListBox Team_List;
        private System.Windows.Forms.ListBox Notifications_List;
    }
}


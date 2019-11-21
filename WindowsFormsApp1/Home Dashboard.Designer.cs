namespace WindowsFormsApp1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TeamListLabel = new System.Windows.Forms.Label();
            this.Notification_Table = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // Add_Team
            // 
            this.Add_Team.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Add_Team.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Add_Team.Location = new System.Drawing.Point(461, 8);
            this.Add_Team.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Team.Name = "Add_Team";
            this.Add_Team.Size = new System.Drawing.Size(57, 42);
            this.Add_Team.TabIndex = 0;
            this.Add_Team.Text = "Add Team";
            this.Add_Team.UseVisualStyleBackColor = true;
            this.Add_Team.Click += new System.EventHandler(this.button3_Click);
            // 
            // Remove_Team
            // 
            this.Remove_Team.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Remove_Team.Location = new System.Drawing.Point(522, 8);
            this.Remove_Team.Margin = new System.Windows.Forms.Padding(2);
            this.Remove_Team.Name = "Remove_Team";
            this.Remove_Team.Size = new System.Drawing.Size(65, 42);
            this.Remove_Team.TabIndex = 1;
            this.Remove_Team.Text = "Remove Team";
            this.Remove_Team.UseVisualStyleBackColor = true;
            this.Remove_Team.Click += new System.EventHandler(this.button2_Click);
            // 
            // Refresh
            // 
            this.Refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Refresh.Location = new System.Drawing.Point(391, 8);
            this.Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(57, 42);
            this.Refresh.TabIndex = 2;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Settings
            // 
            this.Settings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Settings.Image = global::WindowsFormsApp1.Properties.Resources.settings;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(799, 8);
            this.Settings.Margin = new System.Windows.Forms.Padding(2);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(75, 43);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Settings";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Notifications
            // 
            this.Notifications.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Notifications.AutoSize = true;
            this.Notifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notifications.Location = new System.Drawing.Point(615, 18);
            this.Notifications.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Notifications.Name = "Notifications";
            this.Notifications.Size = new System.Drawing.Size(109, 20);
            this.Notifications.TabIndex = 4;
            this.Notifications.Text = "Notifications";
            this.Notifications.Click += new System.EventHandler(this.label1_Click);
            // 
            // Home_Dashboard
            // 
            this.Home_Dashboard.AutoSize = true;
            this.Home_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_Dashboard.Location = new System.Drawing.Point(16, 18);
            this.Home_Dashboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Home_Dashboard.Name = "Home_Dashboard";
            this.Home_Dashboard.Size = new System.Drawing.Size(149, 20);
            this.Home_Dashboard.TabIndex = 5;
            this.Home_Dashboard.Text = "Home Dashboard";
            this.Home_Dashboard.Click += new System.EventHandler(this.Team_Dashboard_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 567F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 81);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(567, 431);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // TeamListLabel
            // 
            this.TeamListLabel.AutoSize = true;
            this.TeamListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamListLabel.Location = new System.Drawing.Point(15, 53);
            this.TeamListLabel.Name = "TeamListLabel";
            this.TeamListLabel.Size = new System.Drawing.Size(115, 25);
            this.TeamListLabel.TabIndex = 9;
            this.TeamListLabel.Text = "Team List";
            this.TeamListLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Notification_Table
            // 
            this.Notification_Table.AutoScroll = true;
            this.Notification_Table.ColumnCount = 1;
            this.Notification_Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Notification_Table.Location = new System.Drawing.Point(593, 81);
            this.Notification_Table.Name = "Notification_Table";
            this.Notification_Table.RowCount = 60;
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Notification_Table.Size = new System.Drawing.Size(281, 431);
            this.Notification_Table.TabIndex = 10;
            this.Notification_Table.Paint += new System.Windows.Forms.PaintEventHandler(this.Notification_Table_Paint);
            // 
            // HomeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 561);
            this.Controls.Add(this.Notification_Table);
            this.Controls.Add(this.TeamListLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Home_Dashboard);
            this.Controls.Add(this.Notifications);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Remove_Team);
            this.Controls.Add(this.Add_Team);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(923, 600);
            this.Name = "HomeDashboard";
            this.Text = "Home Dashboard";
            this.Load += new System.EventHandler(this.TeamDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Remove_Team;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Label Notifications;
        private System.Windows.Forms.Label Home_Dashboard;
        public System.Windows.Forms.Button Add_Team;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TeamListLabel;
        public System.Windows.Forms.TableLayoutPanel Notification_Table;
    }
}


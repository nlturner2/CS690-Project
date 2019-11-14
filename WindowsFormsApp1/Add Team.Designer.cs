namespace WindowsFormsApp1
{
    partial class Add_Team
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Team_Name = new System.Windows.Forms.Label();
            this.GithubURL = new System.Windows.Forms.Label();
            this.TeamNameBox = new System.Windows.Forms.TextBox();
            this.GithubURLBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(470, 328);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 42);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // Team_Name
            // 
            this.Team_Name.AutoSize = true;
            this.Team_Name.Location = new System.Drawing.Point(45, 46);
            this.Team_Name.Name = "Team_Name";
            this.Team_Name.Size = new System.Drawing.Size(99, 20);
            this.Team_Name.TabIndex = 2;
            this.Team_Name.Text = "Team Name:";
            this.Team_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // GithubURL
            // 
            this.GithubURL.AutoSize = true;
            this.GithubURL.Location = new System.Drawing.Point(45, 146);
            this.GithubURL.Name = "GithubURL";
            this.GithubURL.Size = new System.Drawing.Size(94, 20);
            this.GithubURL.TabIndex = 3;
            this.GithubURL.Text = "GithubURL:";
            this.GithubURL.Click += new System.EventHandler(this.GithubURL_Click);
            // 
            // TeamNameBox
            // 
            this.TeamNameBox.Location = new System.Drawing.Point(50, 78);
            this.TeamNameBox.Name = "TeamNameBox";
            this.TeamNameBox.Size = new System.Drawing.Size(664, 26);
            this.TeamNameBox.TabIndex = 4;
            this.TeamNameBox.TextChanged += new System.EventHandler(this.TeamNameBox_TextChanged);
            // 
            // GithubURLBox
            // 
            this.GithubURLBox.Location = new System.Drawing.Point(50, 178);
            this.GithubURLBox.Name = "GithubURLBox";
            this.GithubURLBox.Size = new System.Drawing.Size(664, 26);
            this.GithubURLBox.TabIndex = 5;
            this.GithubURLBox.TextChanged += new System.EventHandler(this.GithubURLBox_TextChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(225, 328);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 42);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.GithubURLBox);
            this.Controls.Add(this.TeamNameBox);
            this.Controls.Add(this.GithubURL);
            this.Controls.Add(this.Team_Name);
            this.Controls.Add(this.Cancel);
            this.Name = "Add_Team";
            this.Text = "Add Team";
            this.Load += new System.EventHandler(this.Add_Team_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label Team_Name;
        private System.Windows.Forms.Label GithubURL;
        private System.Windows.Forms.TextBox TeamNameBox;
        private System.Windows.Forms.TextBox GithubURLBox;
        private System.Windows.Forms.Button Add;
    }
}
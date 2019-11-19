namespace WindowsFormsApp1
{
    partial class Settings
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
            this.Save_Teams = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save_Members = new System.Windows.Forms.Button();
            this.MembersBox = new System.Windows.Forms.TextBox();
            this.TeamBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save_Teams
            // 
            this.Save_Teams.Location = new System.Drawing.Point(298, 149);
            this.Save_Teams.Name = "Save_Teams";
            this.Save_Teams.Size = new System.Drawing.Size(75, 23);
            this.Save_Teams.TabIndex = 0;
            this.Save_Teams.Text = "Save";
            this.Save_Teams.UseVisualStyleBackColor = true;
            this.Save_Teams.Click += new System.EventHandler(this.SaveTeam_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(165, 254);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save_Members
            // 
            this.Save_Members.Location = new System.Drawing.Point(298, 90);
            this.Save_Members.Name = "Save_Members";
            this.Save_Members.Size = new System.Drawing.Size(75, 23);
            this.Save_Members.TabIndex = 2;
            this.Save_Members.Text = "Save";
            this.Save_Members.UseVisualStyleBackColor = true;
            this.Save_Members.Click += new System.EventHandler(this.SaveMembers_Click);
            // 
            // MembersBox
            // 
            this.MembersBox.HideSelection = false;
            this.MembersBox.Location = new System.Drawing.Point(215, 92);
            this.MembersBox.Name = "MembersBox";
            this.MembersBox.Size = new System.Drawing.Size(32, 20);
            this.MembersBox.TabIndex = 3;
            this.MembersBox.TextChanged += new System.EventHandler(this.Members_TextChanged);
            // 
            // TeamBox
            // 
            this.TeamBox.Location = new System.Drawing.Point(215, 150);
            this.TeamBox.Name = "TeamBox";
            this.TeamBox.Size = new System.Drawing.Size(32, 20);
            this.TeamBox.TabIndex = 4;
            this.TeamBox.TextAlignChanged += new System.EventHandler(this.Team_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Member Notifications";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Team Notifications";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 311);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeamBox);
            this.Controls.Add(this.MembersBox);
            this.Controls.Add(this.Save_Members);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save_Teams);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_Teams;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save_Members;
        private System.Windows.Forms.TextBox MembersBox;
        private System.Windows.Forms.TextBox TeamBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
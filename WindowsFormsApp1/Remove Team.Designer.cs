namespace WindowsFormsApp1
{
    partial class Remove_Team
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
            this.Remove = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Team_Name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(207, 293);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(97, 66);
            this.Remove.TabIndex = 0;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(483, 293);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(97, 66);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Team_Name
            // 
            this.Team_Name.AutoSize = true;
            this.Team_Name.Location = new System.Drawing.Point(132, 103);
            this.Team_Name.Name = "Team_Name";
            this.Team_Name.Size = new System.Drawing.Size(149, 30);
            this.Team_Name.TabIndex = 2;
            this.Team_Name.Text = "Team Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(445, 26);
            this.textBox1.TabIndex = 3;
            // 
            // Remove_Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Team_Name);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Remove);
            this.Name = "Remove_Team";
            this.Text = "Remove Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label Team_Name;
        private System.Windows.Forms.TextBox textBox1;
    }
}
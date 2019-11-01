using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Add_Team : Form 
    {
        HomeDashboard TL = new HomeDashboard();
        public Add_Team()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GithubURL_Click(object sender, EventArgs e)
        {
            
        }

        // Add Team Button
        private void button1_Click(object sender, EventArgs e)
        {
            var name = TeamNameBox.Text;
            var url = GithubURLBox.Text;

            if((name != "")&&(url != ""))
            {         
                Button button = new Button();
                button.Size = new Size(100, 30);
                button.Name = name;
                TL.Show();
                TL.flowLayoutPanel1.Controls.Add(button);
            }
           
            
            Close();
        }
        
        // Cancel Button
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TeamNameBox_TextChanged(object sender, EventArgs e)
        {
            var TM = this.TeamNameBox.Text.Insert(this.TeamNameBox.SelectionStart, "0");
            

        }

        private void GithubURLBox_TextChanged(object sender, EventArgs e)
        {
            var TU = this.TeamNameBox.Text.Insert(this.TeamNameBox.SelectionStart, "0");
        }
    }
}

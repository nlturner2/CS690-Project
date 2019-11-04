using System;
using System.IO;
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

        // Add Button
        public void button1_Click(object sender, EventArgs e)
        {
            var main = Application.OpenForms.OfType<HomeDashboard>().First();
            createTeam(main);

            
            Close();
        }

        // creates a team when Add button is clicked
        public void createTeam(HomeDashboard obj)
        {
            var name = TeamNameBox.Text;
            var url = GithubURLBox.Text;
            

            if ((name != "") && (url != ""))
            {
                Team team = new Team(name, url);
                obj.tableLayoutPanel1.Controls.Add(team.getButton());
                obj.tableLayoutPanel1.Show();
                obj.Show();
                var main = Application.OpenForms.OfType<HomeDashboard>().First();
                //main.teamBook[main.count]=team;
                main.Write(team);

            }

            
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

﻿using System;
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
        public Variables Callingform { get; set; }

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
            main.Display();

            
            Close();
        }

        // creates a team when Add button is clicked
        public void createTeam(HomeDashboard obj)
        {
            //DataConnection dbc = new DataConnection();
            //get team name and url
            var name = TeamNameBox.Text;
            var url = GithubURLBox.Text;
            //string fileName = @"C:\Teamfiles\" + TeamNameBox.Text;
            // check if either box was empty
            if ((name != "") && (url != ""))
            {
                // replaced "!File.Exists(fileName)" with true
                if (true)
                {
                    // create team
                    Team team = new Team(name, url);
                    Variables.db.AddTeam(team);
                    obj.tableLayoutPanel1.Controls.Add(team.getButton());
                    obj.tableLayoutPanel1.Show();
                    obj.Show();
                    var main = Application.OpenForms.OfType<HomeDashboard>().First();
                    Variables.TMInstance.Write(team);
                }
                else
                {
                    MessageBox.Show("Team already exists.");
                }
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
            var TU = this.GithubURLBox.Text.Insert(this.GithubURLBox.SelectionStart, "0");
        }

        private void Add_Team_Load(object sender, EventArgs e)
        {

        }
    }
}

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
        public void Add_Click(object sender, EventArgs e)
        {
            // avoiding creating HomeDashboard instance
            Variables.TMInstance.CreateTeam(Application.OpenForms.OfType<HomeDashboard>().First(), TeamNameBox.Text, GithubURLBox.Text);
            Application.OpenForms.OfType<HomeDashboard>().First().Display();

            
            Close();
        }

        // creates a team when Add button is clicked
        
        
        // Cancel Button
        private void Cancel_Click(object sender, EventArgs e)
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

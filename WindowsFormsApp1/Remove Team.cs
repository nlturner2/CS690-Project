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
    public partial class Remove_Team : Form
    {
        public Variables Callingform { get; set; }
        public Remove_Team()
        {
            InitializeComponent();

        }
        // Remove Team Button
        private void Remove_Click(object sender, EventArgs e)
        {
            var main = Application.OpenForms.OfType<HomeDashboard>().First();
            var name = removeTeamBox.Text;
            Variables.TMInstance.removeTeam(name);
            main.Display();

            Close();
        }
       

        // Cancel Button
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Remove_Team_Load(object sender, EventArgs e)
        {

        }
    }
}

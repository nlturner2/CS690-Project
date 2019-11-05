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
    public partial class Remove_Team : Form
    {
        public Remove_Team()
        {
            InitializeComponent();
        }
        // Remove Team Button
        private void button1_Click(object sender, EventArgs e)
        {
            var main = Application.OpenForms.OfType<HomeDashboard>().First();
            var name = removeTeamBox.Text;
            main.removeTeam(name);


            Close();
        }
       

        // Cancel Button
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

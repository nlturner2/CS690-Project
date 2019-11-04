using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Team_Dashboard : Form
    {
        public Team_Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\CapstoneProjectTemplate-master\CapstoneProjectTemplate-master\README.md");

            if (File.Exists(@"C:\CapstoneProjectTemplate-master\CapstoneProjectTemplate-master\README.md"))
            {
                foreach (string line in lines)
                {
                    TabBox.Text += line + "\n";
                }
            }
            else
            {
                TabBox.Text += "\t" + "No such file exists" + "\n";
            }
        }
        
    } 
}

              
          

        

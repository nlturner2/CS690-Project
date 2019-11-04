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

            // Display the file contents by using a foreach loop.
            //System.Console.WriteLine("Contents of WriteLines2.txt = ");
            if (File.Exists(@"C:\CapstoneProjectTemplate-master\CapstoneProjectTemplate-master\README.md"))
            {


                foreach (string line in lines)
                {
                    // Use a tab to indent each line of the file.
                    richTextBox1.Text += line + "\n";
                }
            }
            else
            {
                richTextBox1.Text += "\t" + "No such file exists" + "\n";
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
        
        
    
}


              
          

        

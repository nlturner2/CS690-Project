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
            //HomeDashboard hme = new HomeDashboard();
           //hme.Show();
            Close();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            summaryrichTextBox1.Clear();
            string[] lines = System.IO.File.ReadAllLines(@"C:\TextFile\content.txt");

            // Display the file contents by using a foreach loop.
            //System.Console.WriteLine("Contents of WriteLines2.txt = ");
            if (System.IO.File.Exists(@"C:\TextFile\content.txt"))
            {


                foreach (string line in lines)
                {
                    // Use a tab to indent each line of the file.
                    summaryrichTextBox1.Text += line + "\n";
                }
            }
            else
            {
                summaryrichTextBox1.Text += "\t" + "No such file exists" + "\n";
            }

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Team_Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
        
        
    
}


              
          

        

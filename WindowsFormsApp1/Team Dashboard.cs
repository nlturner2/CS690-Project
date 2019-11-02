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

        private void tabPage1_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\CapstoneProjectTemplate-master\CapstoneProjectTemplate-master\README.md");
            string txt = Summary.Text;
            for (int i = 0; i < lines.Length; i++)
            {

                //getting textfield name and comparing it with text  
                if (txt == "Summary")
                {
                    //finding this heading in file
                    if (lines[i].Contains("Summary"))
                    {

                        //reading lines and displaying in TabBox

                        TabBox.Text += "\n" + lines[i + 2];
                        if (lines[i].Contains("#"))
                        {
                            break;
                        }


                    }
                }
            }
        }
    }
}


        

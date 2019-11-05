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
using System.Net;

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
            //Close();
            new HomeDashboard().Show();
            this.Hide();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                string u = "https://raw.githubusercontent.com/hergin/CapstoneProjectTemplate/master/README.md";
                string s = client.DownloadString(u);
                summaryrichTextBox1.Text += s;
                for (int i = 0; i < s.Length; i++)
                {



                    //finding this heading in file
                    if (s.Contains("Summary"))
                    {
                        //reading lines and displaying in richTextBox1

                        summaryrichTextBox1.Text += "\n" + s[i + 2];
                        if (s.Contains("#"))
                        {
                            break;
                        }

                    }
                }
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


              
          

        

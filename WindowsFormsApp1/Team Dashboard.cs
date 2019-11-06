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
        Team currentTeam;
        public Team_Dashboard(Team obj)
        {
            InitializeComponent();
            this.Hide();
            currentTeam = obj;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close teamdashboard
            Close();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
            /**
            using (WebClient client = new WebClient())
            {
                string u = currentTeam.Url;
                string s = client.DownloadString(u);
                summaryrichTextBox1.Text += s;
                
            }
    */
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Team_Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
        
        
    
}


              
          

        

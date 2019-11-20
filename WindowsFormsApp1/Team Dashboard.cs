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
using System.Web.Helpers;

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

        private void Home_Click(object sender, EventArgs e)
        {
            //Close teamdashboard
            Close();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {


        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Team_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void TeamMeeting_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void Progress_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filesBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void filesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (filesBox.SelectedItem != null)
            {
                
                string meetingfileNameURL = Variables.parseInstance.URLFactory(currentTeam.Url, "meetings");

                meetingRichTextBox1.Text = Variables.parseInstance.parse_Meeting(Variables.parseInstance.meetingFile(currentTeam.Url, Variables.parseInstance.LoadGithubDataAsync(meetingfileNameURL, "filename"))[filesBox.SelectedIndex]);


            }
          
        }
    }
   
}


              
          

        

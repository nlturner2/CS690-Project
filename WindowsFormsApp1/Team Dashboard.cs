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
        Notification notification = new Notification();
        public Team_Dashboard(Team obj)
        {
            InitializeComponent();
            this.Hide();
            currentTeam = obj;
            notification.loadNoitification(this);
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

        public void Notification_Table2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
}


              
          

        

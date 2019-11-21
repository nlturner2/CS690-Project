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
using System.Net;
using LiteDB;

namespace WindowsFormsApp1
{
    public partial class HomeDashboard : Form
    {
        
        
        public Variables Callingform { get; set; }
        //public variables
        public int count = 0;

        public HomeDashboard()
        {
            
            InitializeComponent();
            Variables.notificationInstance.loadNotification(this);
        }

        //Display teams after the read function
        public void Display()
        {
            this.tableLayoutPanel1.Controls.Clear();
            if (Variables.TMInstance.teamBook.Length != 0 && Variables.TMInstance.teamBook != null) {
                for (int i = 0; i < Variables.TMInstance.teamBook.Length; i++)
                {
                    TeamButton newButton = new TeamButton(Variables.TMInstance.teamBook[i]);
                    this.tableLayoutPanel1.Controls.Add(newButton.getButton());
                }
            }     
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        // Add Team Button
        private void button3_Click(object sender, EventArgs e)
        {
            
            var f2 = new Add_Team();
            f2.Show();
        }


        // Remove Team Button
        private void button2_Click(object sender, EventArgs e)
        {
            var f2 = new Remove_Team();
            f2.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Team_Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void TeamDashboard_Load(object sender, EventArgs e)
        {
            Variables.TMInstance.Read();
            Display();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {


            /*DataConnection db = new DataConnection();


           foreach(TeamMembers item in db.GetMembers())

            {
                if (item.TeamName == "t1")
                {
                    item.CommitNotification = true;
                    db.UpdateMember(item, true);


                }
                
                MessageBox.Show("team: "+ item.TeamName.ToString() + " member:"+ item.MemberName.ToString()+" notification:" +item.CommitNotification.ToString());
            }*/
                
           
            NotificationTriggers nt = new NotificationTriggers();             //List<string> result = new List<string>();
            /*foreach(var item in nt.MeetingDate("https://github.com/Brendenjones12/Student-Engagement-and-Retention-Tool.git", 6))
            {
                //result.Add(item);
                MessageBox.Show(item);
            }*/
           // Boolean x = nt.MeetingDate("https://github.com/Brendenjones12/Student-Engagement-and-Retention-Tool.git", 6);
            Boolean x = nt.MeetingDateCheck("https://github.com/Brysonleeward/PDF-In-Browser-Rendering.git");
            //Boolean y = x.Contains("Meeting Start Time");
            //DateTime y = DateTime.Parse(x);

            //MessageBox.Show(a.ToString());
            // MessageBox.Show(x.ToString());

           // MessageBox.Show(x.ToString());
            //MessageBox.Show(y);
            MessageBox.Show(x.ToString());
            //MessageBox.Show("helllo");


        }
        private void Settings_Click(object sender, EventArgs e)
        {
            var f2 = new Settings();
            f2.Show();

        }
        private void Notifications_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Notification_Table_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}

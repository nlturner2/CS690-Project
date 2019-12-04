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
            if (Variables.db.GetSettings() != null)
            {
                foreach (var item in Variables.db.GetSettings())
                {
                    Variables.SettingsInstance.MembersDays = item.MembersDays;
                    Variables.SettingsInstance.TeamWeeks = item.TeamWeeks;
                }
            }
            else
                Variables.db.UpdateSettings(Variables.SettingsInstance);
            this.DisplayNotifications();
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
        public void DisplayNotifications()
        {
            IList<Triggers> aTrigger = Variables.db.GetTriggers();
            List<Notification> homeNotifications = new List<Notification>();
            foreach (Triggers i in aTrigger)
            {
                if (i.Active)
                {
                    Notification a = new Notification();
                    homeNotifications.Add(a);
                    a.loadNotification(this, i);
                }
            }
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
            //Variables.NTInstance.Refresh();
            //Application.OpenForms.OfType<HomeDashboard>().First().Notification_Table.Controls.Clear();
            //this.DisplayNotifications();

            List<string> list = new List<string>();

            list.Add("10-13-2019_10-19-2019.md");
            list.Add("10-6-2019_10-12-2019.md");
            list.Add("11-10-2019_11-16-2019.md");
            list.Add("11-3-2019_11-9-2019.md");


            //string test = "11-3-2019";
            foreach(var item in Variables.parseInstance.fileNameSorting(list))
            {
                
               
                    MessageBox.Show(item);

                
            }
            /*Variables.NTInstance.Refresh();
            Application.OpenForms.OfType<HomeDashboard>().First().Notification_Table.Controls.Clear();
            this.DisplayNotifications();s
            
            
            Application.OpenForms.OfType<HomeDashboard>().First().Notification_Table.Controls.Clear();
            NotificationTriggers nt = new NotificationTriggers();

            //nt.TriggerCheck();

            //Boolean b = nt.CommitDateCheck("https://github.com/Brendenjones12/Student-Engagement-and-Retention-Tool.git", 6);

            //MessageBox.Show(b.ToString());
            //this.DisplayNotifications();*/

            /* foreach (Triggers item in Variables.db.GetTriggers())

             {
                 //if (item.Type == "teamCommit")
                 //{
                 //item.Active = true;
                 //Boolean x=Variables.NTInstance.CommitHistoryDateCheck(item.Url, 7);
                 //MessageBox.Show(x.ToString());
                 Variables.db.UpdateTriggers(item, true);


                 //}

                //MessageBox.Show("team: " + item.TeamName.ToString() + " \n member:" + item.MemberName.ToString() + " \n notification:" + item.Active.ToString() + " \n URL:" + item.Url);
            }
            this.DisplayNotifications();
                 //MessageBox.Show("team: " + item.TeamName.ToString() + " \n member:" + item.MemberName.ToString() + " \n notification:" + item.Active.ToString() + " \n URL:" + item.Url);
             }*/
            //Variables.NTInstance.CommitHistoryDateCheck(item.Url, MembersDays1)


            // string x = Variables.NTInstance.TriggerCheck();
            //MessageBox.Show(x);


            //DateTime d = DateTime.Today;
            // MessageBox.Show(d.ToString());


            //Variables.db.DeleteSettings();



            /*
            foreach (Triggers item in db.GetTriggers())

            {
                //if (item.Type == "teamCommit")
                //{
                    item.Active = true;
                    db.UpdateTriggers(item, true);


                //}

                MessageBox.Show("team: " + item.TeamName.ToString() + " \n member:" + item.MemberName.ToString() + " \n notification:" + item.Active.ToString()+" \n URL:"+item.Url);
            }
            */
            /*
            DataConnection db = new DataConnection();


           foreach(TeamMembers item in db.GetMembers())

            {
                if (item.TeamName == "t1")
                {
                    item.CommitNotification = true;
                    db.UpdateMember(item, true);


                }
                
                MessageBox.Show("team: "+ item.TeamName.ToString() + " member:"+ item.MemberName.ToString()+" notification:" +item.CommitNotification.ToString());
            }*/




        }
        private void Settings_Click(object sender, EventArgs e)
        {
            var f2 = new Settings();
            f2.Show();
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

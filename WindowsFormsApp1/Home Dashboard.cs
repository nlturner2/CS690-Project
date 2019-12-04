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
                    //string name = i.TeamName + ":" + i.MemberName;
                    //Notification name = new Notification();
                    Notification a = new Notification();
                    homeNotifications.Add(a);
                    a.loadNotification(this, i);
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
            foreach (Button tb in Application.OpenForms.OfType<HomeDashboard>().First().tableLayoutPanel1.Controls)
            {
                tb.Image = null;
            }
            Variables.NTInstance.Refresh();
            
            Application.OpenForms.OfType<HomeDashboard>().First().Notification_Table.Controls.Clear();
            this.DisplayNotifications();
            



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

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
            
        }

        //Display teams after the read function
        public void Display()
        {
            this.tableLayoutPanel1.Controls.Clear();
            if (Variables.TMInstance.teamBook.Length != 0 && Variables.TMInstance.teamBook != null) {
                for (int i = 0; i < Variables.TMInstance.teamBook.Length; i++)
                {
                    this.tableLayoutPanel1.Controls.Add(Variables.TMInstance.teamBook[i].getButton());
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
            
            TeamMembers m1 = new TeamMembers("3rd member", "3rd");
            Team t55 = new Team("3rd", "www.google.com");
            DataConnection db = new DataConnection();
            //db.AddTeam(t55);
            //db.AddMember(m1);
            int x =db.CountMembers();
            string y = db.CountMembers().ToString();

            //MessageBox.Show(x.ToString());
            //MessageBox.Show(y);
            db.DeleteRecord("3rd");
            //MessageBox.Show(x.ToString());
            //MessageBox.Show(y);


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

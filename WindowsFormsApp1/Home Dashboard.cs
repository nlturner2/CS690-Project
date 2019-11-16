﻿using System;
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
        //public variables
        public Team[] teamBook = new Team[1];
        public int count = 0;
        
        public HomeDashboard()
        {
            
            InitializeComponent();
            
        }

        public void Write(Team obj)
        {
            //Create File
            string fileName = @"C:\Teamfiles\" + obj.Name;
            if (!File.Exists(fileName)) 
            {
                FileStream fs = File.Create(fileName);
                fs.Close();

                // open file and write URL to it
                StreamWriter sw = new StreamWriter(fileName);
                sw.WriteLine(obj.Url);

                //resize array and add object to it.
                Array.Resize<Team>(ref teamBook, count + 1);
                teamBook[teamBook.Count() - 1] = obj;
                count = teamBook.Count();
                //close file
                sw.Close();
            }
        }

        public void Read()
        {
            int i = 0;
            string url = "";
            //create folder if none exists
            if (!Directory.Exists(@"C:\Teamfiles"))
            {
                Directory.CreateDirectory(@"C:\Teamfiles");
            }

            //create array of files and set teamBook length
            string[] files = Directory.GetFiles(@"C:\Teamfiles\");
            teamBook = new Team[Directory.GetFiles(@"C:\Teamfiles").Length];

            //read in all the file names and the first line of each file which contains the URL
            for (int iFile = 0; iFile < files.Length; iFile++)
            {
                StreamReader sr = new StreamReader(files[iFile]);
                url = sr.ReadLine();
                sr.Close();
                teamBook[i] = new Team(new FileInfo(files[iFile]).Name, url );
                i++;
            }
            //get the size of teamBook
            count = teamBook.Count();
        }

        //Display teams after the read function
        private void Display()
        {
            if (teamBook.Length != 0 && teamBook != null) {
                for (int i = 0; i < teamBook.Length; i++)
                {
                    this.tableLayoutPanel1.Controls.Add(teamBook[i].getButton());
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
        public void removeTeam(string teamName)
        {
            string team = @"C:\Teamfiles\" + teamName;
            
            //create new smaller temporary array
            Team[] tempTeam = new Team[teamBook.Count() - 1];
            int index = 0;
            if (File.Exists(team)) {
                foreach (Team i in teamBook)
                {
                    //check if a file is in array when it is delete it.
                    if (i.Name != teamName)
                    {

                        tempTeam[index] = i;
                        index++;
                    }
                    else
                    {
                        File.Delete(team);
                        tableLayoutPanel1.Controls.Clear();

                    }
                }
                //resize teamBook array
                count = tempTeam.Count();
                Array.Resize<Team>(ref teamBook, count);
            
                //add all the items back to the original array
                index = 0;
                foreach (Team i in tempTeam)
                {
                    
                    teamBook[index] = i;
                    tableLayoutPanel1.Controls.Add(i.getButton());
                    index++;
                }

                tableLayoutPanel1.Show();
                Show();
            }
            else
            {
                MessageBox.Show("Team does not exist.");
            }
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
            Read();
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

        
    }
    
}

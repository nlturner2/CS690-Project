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

namespace WindowsFormsApp1
{
    public partial class HomeDashboard : Form
    {
        //FileStream fs = new FileStream("teams.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
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
            FileStream fs = File.Create(fileName);
            fs.Close();

            //write URL to it
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine(obj.Url);

            //add object to array
            Array.Resize<Team>(ref teamBook, count + 1);
            teamBook[teamBook.Count() - 1] = obj;
            count = teamBook.Count();
            sw.Close();
        }

        public void Read()
        {

            int i = 0;
       
            string[] files = Directory.GetFiles(@"C:\Teamfiles\");
            string url = "i hate C#";
            teamBook = new Team[Directory.GetFiles(@"C:\Teamfiles").Length];
            for (int iFile = 0; iFile < files.Length; iFile++)
            {
                teamBook[i] = new Team(new FileInfo(files[iFile]).Name, url );
                i++;
            }
            count = teamBook.Count();
        }

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
            
            //MessageBox.Show(team);
            Team[] tempTeam = new Team[teamBook.Count() - 1];
            int index = 0;
            foreach (Team i in teamBook)
            {
                
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
            //Array.Resize<Team>(array: ref main.teamBook, newSize: index +1);
            count = tempTeam.Count();
            Array.Resize<Team>(ref teamBook, count);
            
            index = 0;
            foreach (Team i in tempTeam)
            {
                teamBook[index] = i;
                tableLayoutPanel1.Controls.Add(i.getButton());
            }

            tableLayoutPanel1.Show();
            Show();

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
            //getting data from readme file
            using (WebClient client = new WebClient())
            {
                string u = "https://raw.githubusercontent.com/hergin/CapstoneProjectTemplate/master/README.md";
                string s = client.DownloadString(u );
                MessageBox.Show(s);

            }
            
           
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

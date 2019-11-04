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
            
            StreamWriter sw = new StreamWriter("teams.txt");
            sw.WriteLine(teamBook.Length+1);
            sw.WriteLine(obj.Name);
            sw.WriteLine(obj.Url);
            

            for (int i = 0; i < teamBook.Length; i++)
            {
                sw.WriteLine(teamBook[i].Name);
                sw.WriteLine(teamBook[i].Url);
                
            }
            
            Array.Resize<Team>(ref teamBook, count + 1);
            teamBook[teamBook.Count()-1] = obj;
            count++;


            sw.Close();
        }

        public void Read()
        {
            StreamReader sr = new StreamReader("teams.txt");
            teamBook = new Team[Convert.ToInt32(sr.ReadLine())];

            for (int i = 0; i < teamBook.Length; i++)
            {     
                    teamBook[i] = new Team();
                    teamBook[i].Name = sr.ReadLine();
                    teamBook[i].Url = sr.ReadLine();
                    teamBook[i].getButton().Text = teamBook[i].Name;
                    

            }

            count = teamBook.Count();

            sr.Close();
        }

        private void Display()
        {
            if (teamBook.Length != 0) {
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class TeamButton
    {
        Team newTeam;
        private Button button;

        public TeamButton(Team newTeam)
        {
            this.newTeam = newTeam;
            button.Text = newTeam.Name;
            button.Size = new Size(540, 50);
            //button.Click += button_Click;

        }

        /*public void button_Click(object sender, EventArgs e)
        {


            Team_Dashboard TD = new Team_Dashboard(newTeam);
            try
            {
                using (WebClient client = new WebClient())
                {
                    //getting url
                    string rdmeu = newTeam.Url;
                    rdmeu = URLFactory(rdmeu);
                    //downloading string from url which is store in rdmeu 
                    string s = client.DownloadString(rdmeu);
                    //changing string data into parse_Summary and storing into TD.summaryrichTextBox1
                    TD.summaryrichTextBox1.Text += parse_Summary(s);
                    //changing string data into parse_Members and storing into TD.teamMembersRichTextBox1
                    TD.teamMembersRichTextBox1.Text += parse_Members(s);
                    //changing string data into parse_Meeting and storing into TD.meetingRichTextBox1
                    TD.meetingRichTextBox1.Text += parse_Meeting(s);
                    // Display the some commits in like date, name, and message in weekly progress
                    TD.LoadGithubDataAsync();

                }
                TD.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("There is no data in file");
            }
        }*/

    }
}

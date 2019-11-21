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
    public class TeamButton
    {
        public Variables Callingform { get; set; }
        Team newTeam;

        private Button button;

        public TeamButton(Team aTeam)
        {
            this.newTeam = aTeam;
            button = new Button();
            button.Text = aTeam.Name;
            button.Size = new Size(540, 50);
            button.Click += button_Click;

        }

        public String Text
        {
            get { return Text; }
            set { Text = value; }
        }

        public Button getButton()
        {
            return button;
        }

        public void button_Click(object sender, EventArgs e)
        {

            Team_Dashboard TD = new Team_Dashboard(newTeam);
            try
            {
               
                    //getting url
                string meetingfileNameURL = Variables.parseInstance.URLFactory(newTeam.Url, "meetings");
                MessageBox.Show("1");
                string commitURL = Variables.parseInstance.URLFactory(newTeam.Url, "commit");
                MessageBox.Show("2");
                string readmeURL = Variables.parseInstance.URLFactory(newTeam.Url, "readme");
                // NOTE: THE FOLLOWING LINE DOES NOT WORK WHEN THE MEETING MINUTES FOLDER NAME CONTAINS A SPACE
                //downloading string from url which is store in rdmeu 
                MessageBox.Show("3");
                string readMe = Variables.parseInstance.WebClient(readmeURL);
                MessageBox.Show("4");
                string meetingMinutesFile = Variables.parseInstance.meetingFile(newTeam.Url, Variables.parseInstance.LoadGithubDataAsync(meetingfileNameURL, "filename"))[0];
                //changing string data into parse_Summary and storing into TD.summaryrichTextBox1
                MessageBox.Show("5");
                TD.summaryrichTextBox1.Text += Variables.parseInstance.parse_Summary(readMe);
                //changing string data into parse_Members and storing into TD.teamMembersRichTextBox1
                MessageBox.Show("6");
                TD.teamMembersRichTextBox1.Text += Variables.parseInstance.parse_Members(readMe);
                //changing string data into parse_Meeting and storing into TD.meetingRichTextBox1
                MessageBox.Show("7");
                TD.meetingRichTextBox1.Text += Variables.parseInstance.parse_Meeting(meetingMinutesFile);
                // Display the some commits in like date, name, and message in weekly progress
                foreach(var item in Variables.parseInstance.LoadGithubDataAsync(meetingfileNameURL, "filename"))
                {
                    TD.filesBox.Items.Add(item);
                    //MessageBox.Show("Loop1");

                }
                MessageBox.Show("8");
                foreach (var item in Variables.parseInstance.LoadGithubDataAsync(commitURL, "commit"))
                {
                    TD.Progress_List.Items.Add(item);
                    //MessageBox.Show("Loop2");
                }

                MessageBox.Show("9");
                // removes notifications from the TeamDashboard and redisplays
                TD.Show();
                Application.OpenForms.OfType<Team_Dashboard>().First().Notification_Table2.Controls.Clear();
                Application.OpenForms.OfType<Team_Dashboard>().First().DisplayNotifications();



            }
            catch (Exception)
            {
                MessageBox.Show("Check Team URL or Internet Connection.");
            }
        }

    }
}

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

            Parser parser = new Parser();
            Team_Dashboard TD = new Team_Dashboard(newTeam);
            try
            {
                using (WebClient client = new WebClient())
                {

                    //getting url
                    //MessageBox.Show(newTeam.Url);
                    string meetingfileNameURL = parser.URLFactory(newTeam.Url, "meetings");
                    //MessageBox.Show("2");
                    MessageBox.Show(meetingfileNameURL);
                    string commitURL = parser.URLFactory(newTeam.Url, "commit");
                    //MessageBox.Show("3");
                    string readmeURL = parser.URLFactory(newTeam.Url, "readme");
                    //essageBox.Show("4");
                    string meetingMinutesURL = parser.meetingFileURL(newTeam.Url, parser.LoadGithubDataAsync(meetingfileNameURL, "filename"));
                    //downloading string from url which is store in rdmeu 
                    
                    string readMe = client.DownloadString(readmeURL);
                    string meetingMinutesFile = client.DownloadString(meetingMinutesURL);
                    //changing string data into parse_Summary and storing into TD.summaryrichTextBox1
                    TD.summaryrichTextBox1.Text += parser.parse_Summary(readMe);
                    //changing string data into parse_Members and storing into TD.teamMembersRichTextBox1
                    TD.teamMembersRichTextBox1.Text += parser.parse_Members(readMe);
                    //changing string data into parse_Meeting and storing into TD.meetingRichTextBox1
                    TD.meetingRichTextBox1.Text += parser.parse_Meeting(meetingMinutesFile);
                    // Display the some commits in like date, name, and message in weekly progress
                    
                    foreach (var item in parser.LoadGithubDataAsync(commitURL, "commit"))
                    {
                        TD.Progress_List.Items.Add(item);
                    }
                }
                TD.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("There is no data in file");
            }
        }

    }
}

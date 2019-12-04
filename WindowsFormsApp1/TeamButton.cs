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

        public Button button;    

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
                string commitURL = Variables.parseInstance.URLFactory(newTeam.Url, "commit");
                string readmeURL = Variables.parseInstance.URLFactory(newTeam.Url, "readme");
                // NOTE: THE FOLLOWING LINE DOES NOT WORK WHEN THE MEETING MINUTES FOLDER NAME CONTAINS A SPACE
                //downloading string from url which is store in rdmeu     
                string readMe = Variables.parseInstance.WebClient(readmeURL);
                string meetingMinutesFile = Variables.parseInstance.meetingFile(newTeam.Url, Variables.parseInstance.LoadGithubDataAsync(meetingfileNameURL, "filename"))[0];
                //changing string data into parse_Summary and storing into TD.summaryrichTextBox1
                TD.summaryrichTextBox1.Text += Variables.parseInstance.parse_Summary(readMe);
                //changing string data into parse_Members and storing into TD.teamMembersRichTextBox1
                TD.teamMembersRichTextBox1.Text += Variables.parseInstance.parse_Members(readMe);
                //changing string data into parse_Meeting and storing into TD.meetingRichTextBox1
                TD.meetingRichTextBox1.Text += Variables.parseInstance.parse_Meeting(meetingMinutesFile);
                TD.NotesRichTextBox1.Text += Variables.NotesInstance.ReadNotes(newTeam);
                // Display the some commits in like date, name, and message in weekly progress
                foreach(var item in Variables.parseInstance.LoadGithubDataAsync(meetingfileNameURL, "filename"))
                {
                    TD.filesBox.Items.Add(item);
                }
                foreach (var item in Variables.parseInstance.LoadGithubDataAsync(commitURL, "commit"))
                {
                    TD.Progress_List.Items.Add(item);
                }
                    TD.summaryrichTextBox1.Text += Variables.parseInstance.parse_Summary(readMe);
                    //changing string data into parse_Members and storing into TD.teamMembersRichTextBox1
                    TD.teamMembersRichTextBox1.Text += Variables.parseInstance.parse_Members(readMe);
                    //changing string data into parse_Meeting and storing into TD.meetingRichTextBox1
                    TD.meetingRichTextBox1.Text += Variables.parseInstance.parse_Meeting(meetingMinutesFile);

                    TD.NotesRichTextBox1.Text += Variables.NotesInstance.ReadNotes(newTeam);
                // Display the some commits in like date, name, and message in weekly progress

                TD.filesBox.Items.Clear();
                    foreach(var item in Variables.parseInstance.fileNameSorting(Variables.parseInstance.LoadGithubDataAsync(meetingfileNameURL, "filename")))
                    {

                        //if(item = "")

                        TD.filesBox.Items.Add(item);
                        

                    }

                    foreach (var item in Variables.parseInstance.LoadGithubDataAsync(commitURL, "commit"))
                    {
                        TD.Progress_List.Items.Add(item);
                    }
                
                TD.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Check Team URL or Internet Connection.");
            }
        }
    }
}
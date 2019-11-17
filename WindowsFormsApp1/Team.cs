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
    public class Team
    {
        private string name;
        private string url;
        private Button button;


        public Team()
        {
            button = new Button();
            button.Size = new Size(540, 50);
            button.Click += button_Click;
        }

        public Team(String n, String u)
        {
            name = n;
            url = u;
            meetingNotification = false;
            button = new Button();
            button.Text = n;
            button.Size = new Size(540, 50);
            button.Click += button_Click;
        }

        public Button getButton()
        {
            return button;
        }

        public int Id { get; set; }
        public Boolean meetingNotification { get; set; }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Url
        {
            get { return url; }
            set { url = value; }
        }

        public override string ToString()
        {
            return "Person: " + name + " " + url;
        }

        
        /*public void button_Click(object sender, EventArgs e)
        {

            Parser parser = new Parser();
            Team_Dashboard TD = new Team_Dashboard(this);
            try
            {
                using (WebClient client = new WebClient())
                {
                    //getting url
                    string meetingfileNameURL = parser.URLFactory(this.url,"meetings");
                    string commitURL = parser.URLFactory(this.url,"commit");
                    string readmeURL = parser.URLFactory(this.url,"readme");
                    string meetingMinutesURL = parser.meetingFileURL(this.url, parser.LoadGithubDataAsync(meetingfileNameURL, "filename"));
                    //downloading string from url which is store in rdmeu 
                    //MessageBox.Show(rdmeu);
                    string readMe = client.DownloadString(readmeURL);
                    string meetingMinutesFile = client.DownloadString(meetingMinutesURL);
                    //changing string data into parse_Summary and storing into TD.summaryrichTextBox1
                    TD.summaryrichTextBox1.Text += parser.parse_Summary(readMe);
                    //changing string data into parse_Members and storing into TD.teamMembersRichTextBox1
                    TD.teamMembersRichTextBox1.Text += parser.parse_Members(readMe);
                    //changing string data into parse_Meeting and storing into TD.meetingRichTextBox1
                    TD.meetingRichTextBox1.Text += meetingMinutesFile;
                    // Display the some commits in like date, name, and message in weekly progress
                    
                    foreach(var item in parser.LoadGithubDataAsync(commitURL, "commit"))
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
        }*/
      
           
        internal static bool isNull(Team[] tempTeam)
        {
            throw new NotImplementedException();
        }
    }
}



 
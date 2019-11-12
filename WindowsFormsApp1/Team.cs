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
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Team
    {
        private String name;
        private String url;
        private string summary;
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
            button = new Button();
            button.Text = n;
            button.Size = new Size(540, 50);
            button.Click += button_Click;
        }

        public Button getButton()
        {
            return button;
        }

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
        

        public string URLFactory (string URL)
        {
            string partialText = "";
            if (!String.IsNullOrWhiteSpace(URL))
            {
                int charLocation = URL.IndexOf("m", StringComparison.Ordinal);

                if (charLocation > 0)
                {

                    partialText = URL.Substring(charLocation + 1);
                    int secondLocation = partialText.LastIndexOf('.');
                    partialText = partialText.Remove(secondLocation);
                    partialText = "https://raw.githubusercontent.com" + partialText + "/master/README.md";
                }

            }
            return partialText;
        }
        public void button_Click(object sender, EventArgs e)
        {
            //this.button.Click += (object sender, EventArgs e) =>
            // var mainTD = Application.OpenForms.OfType<Team_Dashboard>().First();
            //mainTD.Show();

            Team_Dashboard TD = new Team_Dashboard(this);
            using (WebClient client = new WebClient())
            {
                string rdmeu = this.url;
                rdmeu = URLFactory(rdmeu);
                string s = client.DownloadString(rdmeu);
                TD.summaryrichTextBox1.Text += parse_Summary(s);
                TD.teamMembersRichTextBox1.Text += parse_Members(s);
                //TD.meetingRichTextBox1.Text += parse_Meeting(s);

            }
            TD.Show();
            
        }
        private string parse_Summary(string data)
        {
            string[] summaryWithH = data.Split('#');
            string[] summary = summaryWithH[3].Split('\n');

            return summary[2];
        }
        private string parse_Members(string data)
        {
            string[] teamMembers = data.Split('\n');
            string Members = null;
            int index = 0;
            foreach(string s in teamMembers)
            {
                if(s.Contains("Team Members") || s.Contains("Team members")|| s.Contains("team Members") || s.Contains("team members"))
                {
                    while (index < teamMembers.Length)
                    {
                        if (teamMembers[index].Contains("Client"))
                            break;
                        if (teamMembers[index] != "\n")
                        {
                            Members += teamMembers[index] + "\n";
                        }
                        index++;
                    }
                    break;
                }
                else
                {
                    index++;
                }
            }

            return Members;
        }
        private string parse_Meeting(string data)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\BookArtsCollaborativeBusinessOperationSoftware-master\BookArtsCollaborativeBusinessOperationSoftware-master\MeetingMinutes\Team\10-7-2019_10-13-2019.md");
            string txt = null;
            /*string format = "yyyy mm dd h:mm ";
            DateTime dateTime = DateTime.ParseExact(txt, format);
            */
            
            for (int i = 0; i < lines.Length; i++)
            {
                //getting textfield name and comparing it with text
                if (lines[i].Contains("Meeting Start Time"))
                {
                    //reading lines and displaying in richTextBox1
                    txt += "\n" + lines[i + 0];
                    txt += "\n" + lines[i + 1];
                    if (lines[i].Contains("#"))
                    {
                        break;
                    }
                }

            }
            return txt;
        }


        internal static bool isNull(Team[] tempTeam)
        {
            throw new NotImplementedException();
        }
    }
}

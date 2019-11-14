using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Web.Helpers;

namespace WindowsFormsApp1
{
    public partial class Team_Dashboard : Form
    {
        Team currentTeam;
        public Team_Dashboard(Team obj)
        {
            InitializeComponent();
            this.Hide();
            currentTeam = obj;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close teamdashboard
            Close();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
            /**
            using (WebClient client = new WebClient())
            {
                string u = currentTeam.Url;
                string s = client.DownloadString(u);
                summaryrichTextBox1.Text += s;
                
            }
            */
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {


        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Team_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void TeamMeeting_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void Progress_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void LoadGithubDataAsync()
        {
            string line = null;
            string responseString = "";
            //Create a request object to call Github API
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(" https://api.github.com/repos/MikeyG677/BookArtsCollaborativeBusinessOperationSoftware/contents/MeetingMinutes/Team?ref=master"));
            //GitHub API will reject any request without this header
            request.UserAgent = "my user agent";
            //Add compression headers
            request.AutomaticDecompression = DecompressionMethods.GZip;
            //Get the response from the GitHub API
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            //Read the response in a stream
            using (Stream stream = response.GetResponseStream())
            //Read the stream
            using (StreamReader reader = new StreamReader(stream))
            {
                //Store the response as JSON string in a local variable
                responseString = reader.ReadToEnd();
            }
            //Convert the JSON string to a C# object
            
            dynamic data = Json.Decode(responseString);
            for (int i = 0; i < data.Length; i++)
            {
                //line = data[i].commit.committer.date + ": " + data[i].commit.author.name + ": " + data[i].commit.message;
                line = data[i].name;
                //Loop through the object and add items to the UI.
                Progress_List.Items.Add(line);
                //Check the data object from watch window. You can loop through it and find different properties as you want
            }

        }

    }
   
}


              
          

        

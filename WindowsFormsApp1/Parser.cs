using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Helpers;

namespace WindowsFormsApp1
{
    public class Parser
    {
        private string teamURL;


        public string URL_Readme(string URL)
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


        /*private string parse_Summary(string data)
        {
            string[] summaryWithH = data.Split('\n');
            string summary = null;
            int index = 0;
            foreach (string s in summaryWithH)
            {
                if (s.Contains("Summary") || s.Contains("summary"))
                {
                    while (index < summaryWithH.Length)
                    {
                        if (summaryWithH[index + 1].Contains("Team"))
                            break;
                        else if (summaryWithH[index + 1] != "\n")
                        {
                            summary += summaryWithH[index + 1];
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
            summary = summary.Replace("-", "");
            summary = summary.Replace("\t", "");
            summary = summary.Trim();

            return summary;


        }
        private string parse_Members(string data)
        {
            string[] teamMembers = data.Split('\n');
            string Members = null;
            int index = 0;
            foreach (string s in teamMembers)
            {
                if (s.Contains("Team Members") || s.Contains("Team members") || s.Contains("team Members") || s.Contains("team members"))
                {
                    while (index < teamMembers.Length)
                    {
                        if (teamMembers[index + 1].Contains("Client"))
                            break;
                        else if (teamMembers[index + 1] != "\n")
                        {
                            teamMembers[index + 1] = teamMembers[index + 1].Replace("-", "");
                            teamMembers[index + 1] = teamMembers[index + 1].Replace("\t", "");
                            teamMembers[index + 1] = teamMembers[index + 1].Trim();
                            Members += teamMembers[index + 1] + "\n";
                            TeamMembers team = new TeamMembers(teamMembers[index + 1], this.Name);
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
            Members = Members.Trim();
            return Members;
        }*/


        public List<string> LoadGithubDataAsync()
        {
            List<string> list = new List<string>();
            string line = null;
            string responseString = "";
            //Create a request object to call Github API
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(" https://api.github.com/repos/MikeyG677/BookArtsCollaborativeBusinessOperationSoftware/commits"));
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
                list.Add(line);
                //Loop through the object and add items to the UI.
                //Progress_List.Items.Add(line);
                //Check the data object from watch window. You can loop through it and find different properties as you want
            }

            return list;

        }

        private string parse_Meeting(string data)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\BookArtsCollaborativeBusinessOperationSoftware-master\BookArtsCollaborativeBusinessOperationSoftware-master\MeetingMinutes\Team\10-7-2019_10-13-2019.md");
            string txt = null;
            for (int i = 0; i < lines.Length; i++)
            {
                foreach (string line in lines)
                {
                    // Use a tab to indent each line of the file.
                    txt += line + "\n";
                }
                break;
            }
            return txt;
        }
    }
}

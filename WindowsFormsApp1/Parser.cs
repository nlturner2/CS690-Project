using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Helpers;

namespace WindowsFormsApp1
{
    public class Parser
    {

        //private string teamURL;
        /// <summary>
        /// get URL for readme file, meeting file and commit history.
        /// </summary>
        /// <returns>The actory.</returns>
        /// <param name="URL">URL.</param> The team URL 
        /// <param name="options">Options.</param> Have options to get url for readme file, meeting file, and commit history
        public string URLFactory(string URL, string options)
        {
            string partialText = "";
            if (!String.IsNullOrWhiteSpace(URL))
            {
                //getting index of URL
                int charLocation = URL.IndexOf("m", StringComparison.Ordinal);
                //if charLocation is not null
                if (charLocation > 0)
                {
                    //getting specfic text from URL and storing it in partialText
                    partialText = URL.Substring(charLocation + 1);
                    //getting partialText last index text and storing it secondLocation
                    int secondLocation = partialText.LastIndexOf('.');
                    //removing that index which is store in secondLocation from partialText and storing it in partialText
                    partialText = partialText.Remove(secondLocation);
                    //checking options
                    switch (options)
                    {
                        //if readme is called
                        case "readme":
                            //url is sroting in partialText
                            partialText = "https://raw.githubusercontent.com" + partialText + "/master/README.md";
                            break;
                        //if meetings is called
                        case "meetings":
                            //url is sroting in partialText
                            partialText = "https://api.github.com/repos" + partialText + "/contents/MeetingMinutes/Team?ref=master";
                            break;
                        //if commit is called
                        case "commit":
                            //url is sroting in partialText
                            partialText = "https://api.github.com/repos" + partialText + "/commits";
                            break;
                    }

                }

            }
            return partialText;
        }

        public List<string> meetingFile(string URL,List<string> fileNames)
        {
            List<string> fileContentList = new List<string>();
            string partialText = "";
            if (!String.IsNullOrWhiteSpace(URL))
            {
                //getting index of url
                int charLocation = URL.IndexOf("m", StringComparison.Ordinal);

                if (charLocation > 0)
                {
                    foreach (var fileName in fileNames)
                    {
                        //getting specific text from URL
                        partialText = URL.Substring(charLocation + 1);
                        //getting partialText last index text and storing it secondLocation
                        int secondLocation = partialText.LastIndexOf('.');
                        //removing that index which is store in secondLocation from partialText and storing it in partialText
                        partialText = partialText.Remove(secondLocation);
                        //stroing url in partialText
                        partialText = "https://raw.githubusercontent.com" + partialText + "/master/MeetingMinutes/Team/" + fileName;
                        fileContentList.Add(WebClient(partialText));




                    }

                }
            }
            return fileContentList;
        }

        

        public string WebClient(string rawFileUrl)
        {
            string file = "";
            using (WebClient client = new WebClient())
            {
                //getting file data from rawFileUrl and storing in file
                file = client.DownloadString(rawFileUrl);
            }

            //returning file
            return file;
        }

        public string parse_Summary(string data)
        {
            //removing \n from an array
            string[] summaryWithH = data.Split('\n');
            string summary = null;
            int index = 0;
            //used foreach loop on an array summaryWithH
            foreach (string s in summaryWithH)
            {
                //if s is containing Summarym or summary
                if (s.Contains("Summary") || s.Contains("summary"))
                {
                    // while index value is less then summaryWithH.Length
                    while (index < summaryWithH.Length)
                    {
                        //if specific index of summaryWithH contains Team
                        if (summaryWithH[index + 1].Contains("Team"))
                            //break the loop
                            break;
                        //if specific index of summaryWithH contains \n 
                        else if (summaryWithH[index + 1] != "\n")
                        {
                            //attach summaryWithH specific index into summary
                            summary += summaryWithH[index + 1];
                        }
                        //incerementing index
                        index++;
                    }
                    //breaking foreach loop
                    break;
                }
                else
                {
                    //incrementing index
                    index++;
                }
            }
            //replacing - with ""
            summary = summary.Replace("-", "");
            //replacing \t with ""
            summary = summary.Replace("\t", "");
            summary = summary.Trim();

            return summary;


        }
        public string parse_Members(string data)
        {
            //removing \n from an array
            string[] teamMembers = data.Split('\n');
            string Members = null;
            int index = 0;
            //used foreach loop on an array teamMembers
            foreach (string s in teamMembers)
            {
                //if s is containing Team Members or Team members or team members or team Members
                if (s.Contains("Team Members") || s.Contains("Team members") || s.Contains("team Members") || s.Contains("team members"))
                {
                    // while index value is less then teamMembers.Length
                    while (index < teamMembers.Length)
                    {
                        //if specific index of teamMembers contains Client
                        if (teamMembers[index + 1].Contains("Client"))
                            break;
                        //if specific index of teamMembers contains \n 
                        else if (teamMembers[index + 1] != "\n")
                        {
                            //replacing - with ""
                            teamMembers[index + 1] = teamMembers[index + 1].Replace("-", "");
                            //replacing \t with ""
                            teamMembers[index + 1] = teamMembers[index + 1].Replace("\t", "");
                            //triming indexs
                            teamMembers[index + 1] = teamMembers[index + 1].Trim();
                            //adding line break in teamMembers index and joining with members
                            Members += teamMembers[index + 1] + "\n";
                        }
                        //incrementing
                        index++;
                    }
                    //break loop
                    break;
                }
                else
                {
                    //incrementing
                    index++;
                }
            }
            //triming members
            Members = Members.Trim();
            //returing it from where it is being called
            return Members;
        }


        public List<string> LoadGithubDataAsync(string apiURL,string options)
        {
            //creating list string 
            List<string> list = new List<string>();
            string line = null;
            string responseString = "";
            //Create a request object to call Github API
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(apiURL));
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
                //getting values store in options
                switch (options)
                {
                    //if commit is called
                    case "commit":
                        if (i <= 3)
                        {
                            line = data[i].commit.committer.date + " .  " + data[i].commit.author.name + " . " + "\t" + "         " + data[i].commit.message;

                        }
                        else
                        {
                            line = data[i].commit.committer.date + " .  " + data[i].commit.author.name + " .  " + data[i].commit.message;
                        }
                        break;
                    //if username is called
                    case "username":
                        line = data[i].commit.author.name;
                        break;
                    //if filename is called
                    case "filename":
                        line = data[i].name;
                        break;
                    default:
                        line = data[i];
                        break;

                

            }
               
                list.Add(line);
                //Loop through the object and add items to the UI.
                
                //Check the data object from watch window. You can loop through it and find different properties as you want
            }

            return list;

        }

        public string parse_Meeting(string data)
        {
            data = data.Replace("#", "");
            data = data.Replace("*", "");
            data = data.Replace("-", "");
            return data;
        }
    }
}

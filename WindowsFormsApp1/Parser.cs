using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web.Helpers;

namespace WindowsFormsApp1
{
    public class Parser
    {

        
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
                        case "contents":
                            partialText = "https://api.github.com/repos" + partialText + "/contents";
                            break;
                        case "readme":
                            //url is sroting in partialText
                            partialText = "https://raw.githubusercontent.com" + partialText + "/master/README.md";
                            break;
                        
                        case "meetings":
                            
                            partialText = "https://api.github.com/repos" + partialText + "/contents/MeetingMinutes/Team?ref=master";
                            break;
                        
                        case "commit":
                            
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
                        
                        partialText = URL.Substring(charLocation + 1);
                        
                        int secondLocation = partialText.LastIndexOf('.');
                        
                        partialText = partialText.Remove(secondLocation);
                       
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
                //if s is containing Summary or summary
                if (s.Contains("Summary") || s.Contains("summary"))
                {
                    // while index value is less then summaryWithH.Length
                    while (index < summaryWithH.Length)
                    {
                        //if specific index of summaryWithH contains Team
                        if (summaryWithH[index + 1].Contains("Team"))
                            break;
                        //if specific index of summaryWithH contains \n 
                        else if (summaryWithH[index + 1] != "\n")
                        {
                            //attach summaryWithH specific index into summary
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
            //replacing - with ""
            summary = summary.Replace("-", "");
            //replacing \t with ""
            summary = summary.Replace("\t", "");
            summary = summary.Trim();

            return summary;
        }


        public string parse_Members(string data)
        {
            
            string[] teamMembers = data.Split('\n');
            string Members = null;
            int index = 0;
            
            foreach (string s in teamMembers)
            {
                //if s is containing Team Members or Team members or team members or team Members
                if (s.Contains("Team Members") || s.Contains("Team members") || s.Contains("team Members") || s.Contains("team members"))
                {
                    
                    while (index < teamMembers.Length)
                    {
                        //if specific index of teamMembers contains Client
                        if (teamMembers[index + 1].Contains("Client"))
                            break;
                        //if specific index of teamMembers contains \n 
                        else if (teamMembers[index + 1] != "\n")
                        {
                            teamMembers[index + 1] = teamMembers[index + 1].Replace("-", "");
                            teamMembers[index + 1] = teamMembers[index + 1].Replace("\t", "");
                            teamMembers[index + 1] = teamMembers[index + 1].Trim();
                            //adding line break in teamMembers index and joining with members
                            Members += teamMembers[index + 1] + "\n";
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
            //triming members
            Members = Members.Trim();
            
            return Members;
        }



        /// <summary>
        /// taking url and convert it to api, after that getting json file for api and start read data for commit history
        /// </summary>
        /// <param name="apiURL"></param> The team api for URL
        /// <param name="options"></param>Have options to load data for commit history from apiurl as json
        /// <returns></returns>
        //this is using the API to send request
        public List<string> LoadGithubDataAsync(string apiURL,string options)
        {
            //List of string 
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
                        //line = data[i].commit.committer.date + " .  " + data[i].commit.author.name + " . " + "\t"  + data[i].commit.message;
                        line = String.Format("{0,-25} | {1,-25} | {2,0}", data[i].commit.committer.date, data[i].commit.author.name, data[i].commit.message);
                        break;
                   
                    case "username":
                        line = data[i].commit.author.name;
                        break;
                    
                    case "filename":
                        line = data[i].name;
                        break;
                    case "date":
                        line = data[i].commit.committer.date;
                        break;
                    default:
                        line = data[i];
                        break;

                

            }

                //Loop through the object and add items to the UI.
                list.Add(line);

            }

            return list;

        }


        public List<string> fileNameSorting(List<string> list)
        {
            List<DateTime> timeList = new List<DateTime>();
            List<string> stringList = new List<string>();

            //Dictionary<DateTime, string> dict = new Dictionary<DateTime, string>();

            //dict.Clear();
            string template ="";
            var tupleList = new List<(DateTime, string)>();
            foreach (var item in list)
            {
                
                if (Char.IsDigit(item[0]))
                {
                    int LineLocation = item.IndexOf("_", StringComparison.Ordinal);
                    string date = item.Remove(LineLocation);
                    date = date.Replace('-', '/');
                    DateTime dateTime = DateTime.Parse(date);
                    timeList.Add(dateTime);
                    //dict.Add(dateTime,item);
                    tupleList.Add((dateTime, item));
                }
                else
                {
                    template = item;
                }
                
            }

            tupleList.Sort((x,y)=> y.Item1.CompareTo(x.Item1));

            //var sortedList = dict.Keys.OrderByDescending(e => e).ToList();

            List<string> resultList = new List<string>();
            foreach(var item in tupleList)
            {
                resultList.Add(item.Item2);
            }
            resultList.Add(template);
            return resultList;
        }



        public string parse_Meeting(string data)
        {
            data = data.Replace("#", "");
            data = data.Replace("*", "");
            data = data.Replace("-", "");
            return data;
        }
        public List<string> usernameFilter(List<string> list)
        {
            list = list.Distinct().ToList();

            return list;
        }
    }
}

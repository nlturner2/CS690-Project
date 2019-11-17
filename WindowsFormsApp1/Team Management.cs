using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    public class TeamManagement
    {
        /* To use Functions from this class or variables from this class in other places put 
         * "Variables.TM"
         * in front of them.
         */
        public Team[] teamBook = new Team[1];
        public int count = 0;

        public void removeTeam(string teamName)
        {
            string team = @"C:\Teamfiles\" + teamName;

            //create new smaller temporary array
            Team[] tempTeam = new Team[teamBook.Count() - 1];
            int index = 0;
            if (File.Exists(team))
            {
                foreach (Team i in teamBook)
                {
                    //check if a file is in array when it is delete it.
                    if (i.Name != teamName)
                    {
                        tempTeam[index] = i;
                        index++;
                    }
                    else
                    {
                        File.Delete(team);
                    }
                }
                //resize teamBook array
                count = tempTeam.Count();
                Array.Resize<Team>(ref teamBook, count);

                //add all the items back to the original array
                index = 0;
                foreach (Team i in tempTeam)
                {
                    teamBook[index] = i;
                    index++;
                }
            }
        }
        public void Write(Team obj)
        {
            //Create File
            string fileName = @"C:\Teamfiles\" + obj.Name;
            if (!File.Exists(fileName))
            {
                FileStream fs = File.Create(fileName);
                fs.Close();

                // open file and write URL to it
                StreamWriter sw = new StreamWriter(fileName);
                sw.WriteLine(obj.Url);

                //resize array and add object to it.
                Array.Resize<Team>(ref teamBook, count + 1);
                teamBook[teamBook.Count() - 1] = obj;
                count = teamBook.Count();
                //close file
                sw.Close();
            }
        }
        public void Read()
        {
            int i = 0;
            string url = "";
            //create folder if none exists
            if (!Directory.Exists(@"C:\Teamfiles"))
            {
                Directory.CreateDirectory(@"C:\Teamfiles");
            }

            //create array of files and set teamBook length
            string[] files = Directory.GetFiles(@"C:\Teamfiles\");
            teamBook = new Team[Directory.GetFiles(@"C:\Teamfiles").Length];

            //read in all the file names and the first line of each file which contains the URL
            for (int iFile = 0; iFile < files.Length; iFile++)
            {
                StreamReader sr = new StreamReader(files[iFile]);
                url = sr.ReadLine();
                sr.Close();
                teamBook[i] = new Team(new FileInfo(files[iFile]).Name, url);
                i++;
            }
            //get the size of teamBook
            count = teamBook.Count();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    public class Notes
    {
        public void WriteNotes(Team teams, string note)
        {
            string filepath = @"C:\Teamfiles\" + teams.Name;
            //check directory exists
            if (!Directory.Exists(@"C:\Teamfiles"))
            {
                Directory.CreateDirectory(@"C:\Teamfiles");
            }
            //deletes file if one exists
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }
            //writes all notes to a new file.
            File.WriteAllText(filepath,note);
        }
        public string ReadNotes(Team teams)
        {
            string s= null;
            string filepath = @"C:\Teamfiles\" + teams.Name;
            if (!File.Exists(filepath))
            {
                //if File doesn't exist do nothing
            }
            else
            {
                //add info in notes file to notes tab
                foreach (var line in File.ReadLines(filepath))
                {
                    s += line + "\n";
                }
            }
            return s;
        }
    }
}

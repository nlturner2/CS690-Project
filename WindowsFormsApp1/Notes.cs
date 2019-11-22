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
            if (!Directory.Exists(@"C:\Teamfiles"))
            {
                Directory.CreateDirectory(@"C:\Teamfiles");
            }
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }

            File.WriteAllText(filepath,note);

        }
        public string ReadNotes(Team teams)
        {
            string s= null;
            string filepath = @"C:\Teamfiles\" + teams.Name;
            if (!File.Exists(filepath))
            {

            }
            else
            {
                foreach (var line in File.ReadLines(filepath))
                {
                    s += line + "\n";
                }
            }
            return s;
        }

    }

}

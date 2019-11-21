using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Triggers
    {
        public Triggers()
        {

        }


        public Triggers(string triggerType, string teamName, string url)
        {
            Type = triggerType;
            TeamName = teamName;
            MemberName = "no member";
            Url = url;
            Active = false;
            DismissDate = DateTime.Today.AddDays(-360);
            Settings = 1;
        }
        public Triggers(string triggerType, string teamName, string url, string memberName)
        {
            Type = triggerType;
            TeamName = teamName;
            MemberName = memberName;
            Url = url;
            Active = false;
            DismissDate = DateTime.Today.AddDays(-360);
            Settings = 7;
        }
        public int Id { get; set; }
        public string Type { get; set; }
        public string TeamName { get; set; }
        public string MemberName { get; set; }
        public int Settings { get; set; }

        public string Url { get; set; }

        public Boolean Active { get; set; }
        //public Boolean Dismissed { get; set; }
        public DateTime DismissDate { get; set; }
    }
}

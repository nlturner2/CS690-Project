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
            Active = false;
            DismissDate = DateTime.Today.AddDays(-360);
        }
        public Triggers(string triggerType, string teamName, string url, string memberName)
        {
            Type = triggerType;
            TeamName = teamName;
            MemberName = memberName;
            Active = false;
            DismissDate = DateTime.Today.AddDays(-360);
        }
        public int Id { get; set; }
        public string Type { get; set; }
        public string TeamName { get; set; }
        public string MemberName { get; set; }


        public Boolean Active { get; set; }
        public DateTime DismissDate { get; set; }
    }
}

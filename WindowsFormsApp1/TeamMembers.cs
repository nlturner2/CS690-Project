using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class TeamMembers
    {


        public TeamMembers()
        {
            
        }

        public TeamMembers(string name, string team)
        {
            MemberName = name;
            TeamName = team;
            //CommitNotification = false;
        }
        
        public int Id { get; set; }
        public string MemberName { get; set; }
        public string TeamName { get; set; }
        
    }
}


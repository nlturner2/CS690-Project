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
        //private string memberName;
       // private string teamName;

        public TeamMembers()
        {
            
        }

        public TeamMembers(string name, string team)
        {
            MemberName = name;
            TeamName = team;
            //CommitNotification = false;
        }
        /**
        public t()
        {
            using (var db = new LiteDatabase(@"MyData.db"))
            {
                var collection = db.GetCollection<TeamMembers>("members");
                var member = new TeamMembers(name, team)
                {
                    memberName = name,
                    teamName = team
                };
                collection.Insert(member);
            }
        }
    */
        public int Id { get; set; }
        public string MemberName { get; set; }
        public string TeamName { get; set; }
        //public Boolean CommitNotification { get; set; }
    }
}


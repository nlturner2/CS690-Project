using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    public class DataConnection
    {
        public DataConnection()
        {
            using (var db = new LiteDatabase(@"TrackingData.db"))
            {
                var teamCollection = db.GetCollection<Team>("teams");
                var membersCollection = db.GetCollection<TeamMembers>("members");                
            }
                
        }
        public void AddTeam(Team item)
        {

            using (var db = new LiteDatabase(@"TrackingData.db"))
            {
                var teamCollection = db.GetCollection<Team>("teams");
                teamCollection.Insert(item);
            }
            
        }
        public void AddMember(TeamMembers item)
        {

            using (var db = new LiteDatabase(@"TrackingData.db"))
            {
                var membersCollection = db.GetCollection<TeamMembers>("members");
                membersCollection.Insert(item);
            }
            
        }
        public int CountTeams()
        {
            int count;
            using (var db = new LiteDatabase(@"TrackingData.db"))
            {
                var teamCollection = db.GetCollection<Team>("teams");
                count=teamCollection.Count();
            }
            return count;
        }
        public int CountMembers()
        {
            int count;
            using (var db = new LiteDatabase(@"TrackingData.db"))
            {
                var membersCollection = db.GetCollection<TeamMembers>("members");
                count = membersCollection.Count();
            }
            return count;
        }
        public void DeleteRecord(string theTeam)
        {
            using (var db = new LiteDatabase(@"TrackingData.db"))
            {
                var teamCollection = db.GetCollection<Team>("teams");
                var membersCollection = db.GetCollection<TeamMembers>("members");
                teamCollection.Delete(Query.EQ("Name", theTeam));
                membersCollection.Delete(Query.EQ("TeamName", theTeam));
                
            }
        }
    }
}

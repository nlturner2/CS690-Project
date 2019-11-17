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
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                var teamCollection = db.GetCollection<Team>("teams");
                var membersCollection = db.GetCollection<TeamMembers>("members");                
            }
                
        }
        //Function to add a team to the database, it takes a Team object.
        public void AddTeam(Team item)
        {

            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                var teamCollection = db.GetCollection<Team>("teams");
                teamCollection.Insert(item);
            }
            
        }
        //Function to add members of a team to the database, it take TeamMembers object.
        public void AddMember(TeamMembers item)
        {

            using (var db = new LiteDatabase(@"TrackingData.db"))
            {
                var membersCollection = db.GetCollection<TeamMembers>("members");
                membersCollection.Insert(item);
            }
            
        }

        //Function to count the number of teams in the database
        public int CountTeams()
        {
            int count;
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                var teamCollection = db.GetCollection<Team>("teams");
                count=teamCollection.Count();
            }
            return count;
        }

        //Function to count the number of members in the database
        public int CountMembers()
        {
            int count;
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                var membersCollection = db.GetCollection<TeamMembers>("members");
                count = membersCollection.Count();
            }
            return count;
        }

        //Function to delete the team and the members that belongs to that team. it takes the string team name
        public void DeleteRecord(string theTeam)
        {
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                var teamCollection = db.GetCollection<Team>("teams");
                var membersCollection = db.GetCollection<TeamMembers>("members");
                teamCollection.Delete(Query.EQ("Name", theTeam));
                membersCollection.Delete(Query.EQ("TeamName", theTeam));
                
            }
        }

        //return a list of team

        public IList<Team> GetAll()
        {
            var teamToReturn = new List<Team>();
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                var teamCollection = db.GetCollection<Team>("teams");
                var results = teamCollection.FindAll();
                foreach (Team teamItem in results)
                {
                    teamToReturn.Add(teamItem);
                }
                return teamToReturn;
            }
        }
        public void UpdateNotification(string theTeam)
        {
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                // Open data file (or create if not exits)  
                var teamCollection = db.GetCollection<Team>("teams");
                
                    // Update an existing issue document  
                    
                    var updateTeam = teamCollection.Find(Query.EQ("Name", theTeam));
                //updateTeam.meetingNotification = true;
                teamCollection.Update(updateTeam);

            }
        }
        public string ReadTeam()
        {
            return "a";
        }
    }
}

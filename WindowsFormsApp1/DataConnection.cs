using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                var triggersCollection = db.GetCollection<Triggers>("triggers");
            }
        }
        //Function to add a team to the database, it takes a Team object.
        public void Add(Object item)
        {
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                if(item is Team)
                    
                {
                    var teamCollection = db.GetCollection<Team>("teams");
                    teamCollection.Insert((Team)item);
                }
                if (item is TeamMembers)
                {
                    var membersCollection = db.GetCollection<TeamMembers>("members");
                    membersCollection.Insert((TeamMembers)item);
                }
                if (item is Triggers)
                {
                    var triggersCollection = db.GetCollection<Triggers>("triggers");
                    triggersCollection.Insert((Triggers)item);
                }
            }
        }
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
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                var membersCollection = db.GetCollection<TeamMembers>("members");
                membersCollection.Insert(item);
            }
        }
        public void AddTriggers(Triggers item)
        {
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                var triggersCollection = db.GetCollection<Triggers>("triggers");
                triggersCollection.Insert((Triggers)item);
            }
        }
        public void AddSettings(SettingsData item)
        {

            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                var settingsCollection = db.GetCollection<SettingsData>("settings");
                settingsCollection.Insert(item);
            }

        }
        //Function to add members of a team to the database, it take TeamMembers object.

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
        public int CountTriggers()
        {
            int count;
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                var triggersCollection = db.GetCollection<Triggers>("triggers");
                count = triggersCollection.Count();
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
                var triggersCollection = db.GetCollection<Triggers>("triggers");
                teamCollection.Delete(Query.EQ("Name", theTeam));
                membersCollection.Delete(Query.EQ("TeamName", theTeam));
                triggersCollection.Delete(Query.EQ("TeamName", theTeam));
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
        public IList<TeamMembers> GetMembers()
        {
            var teamToReturn = new List<TeamMembers>();
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                var membersCollection = db.GetCollection<TeamMembers>("members");
                var results = membersCollection.FindAll();
                foreach (TeamMembers memberItem in results)
                {
                    teamToReturn.Add(memberItem);
                }
                return teamToReturn;
            }
        }
        public IList<Triggers> GetTriggers()
        {
            var triggerToReturn = new List<Triggers>();
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                var triggersCollection = db.GetCollection<Triggers>("triggers");
                var results = triggersCollection.FindAll();
                foreach (Triggers triggerItem in results)
                {
                    triggerToReturn.Add(triggerItem);
                }
                return triggerToReturn;
            }
        }
        public IList<SettingsData> GetSettings()
        {
            var settingsToReturn = new List<SettingsData>();
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                var settingsCollection = db.GetCollection<SettingsData>("settings");
                var results =settingsCollection.FindAll();
                foreach (SettingsData settingsItem in results)
                {
                    settingsToReturn.Add(settingsItem);
                }
                return settingsToReturn;
            }
        }
        public void UpdateTriggers(Triggers atrigger, Boolean x)
        {
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                // Open data file (or create if not exits)  
                var triggersCollection = db.GetCollection<Triggers>("triggers");

                atrigger.Active = x;
                triggersCollection.Update(atrigger);

            }
        }
        public void UpdateSettings(SettingsData item)
        {
            int count = 0;
            foreach (SettingsData i in Variables.db.GetSettings())
            {
                count++;
            }
            if (count == 0)
            {
                Variables.db.AddSettings(Variables.SettingsInstance);
            }
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                var settingsCollection = db.GetCollection<SettingsData>("settings");
                settingsCollection.Update(item);
            }
        }
        public void UpdateTriggerDismiss(Triggers atrigger, DateTime dismissDate)
        {
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                // Open data file (or create if not exits)  
                var triggersCollection = db.GetCollection<Triggers>("triggers");
                atrigger.DismissDate = dismissDate;
                triggersCollection.Update(atrigger);
            }
        }

        public Boolean CheckTeam(string theName, string theUrl)
        {
            Boolean result;
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                var teamCollection = db.GetCollection<Team>("teams");
                var nameResult = teamCollection.Exists(Query.EQ("Name", theName));
                var urlResult = teamCollection.Exists(Query.EQ("Url", theUrl));
                result = nameResult || urlResult;
            }
            return result;
        }
    }
}

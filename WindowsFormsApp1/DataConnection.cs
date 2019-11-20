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

        public void DeleteSettings()
        {
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                var settingsCollection = db.GetCollection<SettingsData>("settings");
                settingsCollection.Delete(Query.All());
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

        
        /*
                public List<Team> StartProgram()
                {
                    var teamToReturn = new List<Team>();
                    using (var db = new LiteDatabase(@"TestDataBase1.db"))
                    {
                        var teamCollection = db.GetCollection<Team>("teams");
                        int numberOfTeams = teamCollection.Count();

                        for (int i = 0; i <= numberOfTeams;i++ )
                        {

                        }

                    }
                    return teamToReturn;
                }
                */
        /*
        public void UpdateNotification(string theTeam)
        {
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                // Open data file (or create if not exits)  
                var teamCollection = db.GetCollection<Team>("teams");

                // Update an existing issue document  

                IList<Team> updateTeam = teamCollection.Find(Query.EQ("Name", theTeam));
                Team thisTeam = updateTeam;
                //updateTeam.meetingNotification = true;
                teamCollection.Update(updateTeam);

            }
        }
        */
        public void Update(Object x,string y)
        {
            if (x is Team)
            {

            }
            else if(x is TeamMembers){

            }
        }

        public void UpdateMember(TeamMembers aMember,Boolean x )
        {
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                // Open data file (or create if not exits)  
                var membersCollection = db.GetCollection<TeamMembers>("members");

                aMember.CommitNotification = x;

              //var updateTeam = teamCollection.Find(Query.EQ("Name", theTeam));
                //updateTeam.meetingNotification = true;
                membersCollection.Update(aMember);

            }
        }

        public void UpdateTeam(Team aTeam, Boolean x)
        {
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                // Open data file (or create if not exits)  
                var teamCollection = db.GetCollection<Team>("teams");

                aTeam.MeetingNotification = x;

                //var updateTeam = teamCollection.Find(Query.EQ("Name", theTeam));
                //updateTeam.meetingNotification = true;
                teamCollection.Update(aTeam);

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
        /*
        public void UpdateTriggerSettings(Triggers atrigger, int s)
        {
            using (var db = new LiteDatabase(@"TestDataBase1.db"))
            {
                // Open data file (or create if not exits)  
                var triggersCollection = db.GetCollection<Triggers>("triggers");

                atrigger.Settings = s;
                triggersCollection.Update(atrigger);

            }
        }
        */
        public string ReadTeam()
        {
            return "a";
        }
    }
}

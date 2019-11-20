using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class NotificationTriggers
    {

        private int TeamDays1 = 7;
        private int TeamDays2 = 14;
        private int MembersDays1 = 7;
        private int MembersDays2 = 14;
        public Variables Callingform { get; set; }

        public NotificationTriggers()
        {

        }

        public string TriggerCheck()
        {
            // tracking progress
            string s = "";
            foreach (Triggers item in Variables.db.GetTriggers())
            {
                s += "team: " + item.TeamName.ToString() + " member: " + item.MemberName.ToString() + " notification: " + item.Active.ToString() + " date:" + item.DismissDate.ToString()+ "\n  \n";
                if (item.Type == "memberCommit")
                {
                    s +="input1:"+ item.DismissDate + " input2:" + TeamDays1 +" result:"+ DismissCheckForCommit(item.DismissDate, TeamDays1) + "\n  \n";
                    if (DismissCheckForCommit(item.DismissDate, TeamDays1))
                    {
                        s += "input1:" + item.Url + " input2:" + MembersDays1 + " result:" + CommitHistoryDateCheck(item.Url, MembersDays1) + "\n  \n";
                        if (CommitHistoryDateCheck(item.Url, MembersDays1))
                        {
                            item.Active = false;
                            Variables.db.UpdateTriggers(item, false);
                            //dissmiss notification
                            s += "if result: true and data should be false"+ " notification: " + item.Active.ToString() + " date:" + item.DismissDate.ToString() + "\n  \n";
                        }
                        else
                        {
                            item.Active = true;
                            Variables.db.UpdateTriggers(item, true);
                            item.DismissDate = DateTime.Today;
                            Variables.db.UpdateTriggerDismiss(item, DateTime.Today);
                            //more code to make it apper
                            s += "if result: false and data should be true and date should be todays" + " notification: " + item.Active.ToString() + " date:" + item.DismissDate.ToString() + "\n  \n";
                        }
                    }
                    else
                    {
                        item.Active = false;
                        Variables.db.UpdateTriggers(item, false);
                        //dissmiss notification
                        s += "dismiss if result: false and data should be false" + " notification: " + item.Active.ToString() + " date:" + item.DismissDate.ToString() + "\n \n";
                    }

                }
                if (item.Type == "teamCommit")
                {
                    Boolean status = true;
                    int counter = 0;
                    foreach (Triggers item2 in Variables.db.GetTriggers())
                    {
                        
                        string team = item.TeamName;
                        if (item.Type == "memberCommit" && team == item.TeamName)
                        {
                            status = item.Active && status;
                            counter++;
                        }
                        
                    }
                    if (counter > 0)
                    {
                        item.Active = status;
                        Variables.db.UpdateTriggers(item, status);
                    }
                    else
                    {
                        item.Active = false;
                        Variables.db.UpdateTriggers(item, false);
                    }
                    
                }
                if (item.Type == "teamMeeting")
                {
                    // need to replace this line with the new function
                    //if (DismissCheckForCommit(item.DismissDate))
                    if (false)
                    {
                        //ths function has an error
                        if (MeetingDateCheck(item.Url))
                        {
                            item.Active = false;
                            Variables.db.UpdateTriggers(item, false);
                            //dissmiss notification
                        }
                        else
                        {
                            item.Active = true;
                            Variables.db.UpdateTriggers(item, true);
                            item.DismissDate = DateTime.Today;
                            Variables.db.UpdateTriggerDismiss(item, DateTime.Today);
                            //more code to make it apper
                        }
                    }
                    else
                    {
                        item.Active = false;
                        Variables.db.UpdateTriggers(item, false);
                        //dissmiss notification
                    }
                }
            }
            return s;
        }


  
        public void CommitTrigger(Team aTeam)
        {
            foreach (TeamMembers item in Variables.db.GetMembers())
            {

                if (item.TeamName == aTeam.Name)
                {
                    if (CommitHistoryDateCheck(aTeam.Url, MembersDays1))
                    {
                        item.CommitNotification = false;
                        Variables.db.UpdateMember(item, false);
                        //dissmiss notification
                    }
                    else
                    {
                        item.CommitNotification = true;
                        Variables.db.UpdateMember(item, true);
                        //more code to make it apper
                    }
                }
                
            }
                        
        }
        /*
        public Boolean ProgressTrigger(Array theMembers[])
        {
            Boolean check = false;
            for ( int i = theMembers.Length; TeamMembers aMember in theMembers[])

            {
                if (aMember.CommitNotification)
                {
                    theMembers[].CommitNotification = true;

                }
            }
            return check;
        }
    */
        public void MeetingTrigger(Team aTeam, int lastMeeting, int days)
        {
            if (days < lastMeeting)
            {
                aTeam.MeetingNotification = true;
                //more code to make it apper
            }
            else
            {
                aTeam.MeetingNotification = false;
                //dissmiss notification
            }
        }
        
        
        /// <summary>
        /// to check if the team committed in the past #numberOfDays. 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="numberOfDays"></param>
        /// <returns></returns> return true if they did, return false if they didn't.
        public Boolean CommitHistoryDateCheck (string url, int numberOfDays)         {              Boolean acceptable = true;             List<DateTime> dates = new List<DateTime>();             List<string> datesText = Variables.parseInstance.LoadGithubDataAsync(Variables.parseInstance.URLFactory(url, "commit"), "date");             foreach (var date in datesText)             {                 DateTime dateTime = DateTime.Parse(date);                 dates.Add(dateTime);             }             dates.Sort();             DateTime today = DateTime.Today;             DateTime daysAgo = today.AddDays(-numberOfDays);             int datesCount = dates.Count;             //acceptable = DateTime.Compare(daysAgo, dates[datesCount - 1]);             if (daysAgo > dates[datesCount - 1])             {                 acceptable = false;             }                  return acceptable;         }   


        public Boolean DismissCheckForCommit(DateTime date, int numberOfDays)
        {
            Boolean dismiss = false;
            DateTime today = DateTime.Today;
            date = date.AddDays(+numberOfDays);
            if (today > date)
            {
                dismiss = true;
            }

            return dismiss;
        }
        

        /// <summary>
        /// to check if the team has a meeting file in the previous week
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>if the return value is false, it means the team didn't meet last week, otherwise, it's true. 
        public Boolean MeetingDateCheck (string url)
        {
            //int index = 0;
            Boolean acceptable = true;
            string meetingfileNameURL = Variables.parseInstance.URLFactory(url, "meetings");
            //string meetingMinutesURL = Variables.parseInstance.meetingFileURL(url, Variables.parseInstance.LoadGithubDataAsync(meetingfileNameURL, "filename"));
            List<string> filename = new List<string>();


            DayOfWeek weekStart = DayOfWeek.Monday;
            DateTime startingDate = DateTime.Today;
            while (startingDate.DayOfWeek != weekStart)
                startingDate = startingDate.AddDays(-1);

            DateTime previousWeekStart = startingDate.AddDays(-7);
            DateTime previousWeekEnd = startingDate.AddDays(-1);

            foreach (var item in Variables.parseInstance.LoadGithubDataAsync(meetingfileNameURL, "filename"))
            {
                filename.Add(item);
            }
            foreach (var item in filename)
            {
                int Location = item.LastIndexOf('.');
                var revisedItem = item.Remove(Location);
                string[] list = revisedItem.Split('_');
                string startDate = list[0].Replace('-', '/');
                string endDate = list[1].Replace('-', '/');
                DateTime start = DateTime.Parse(startDate);
                DateTime end = DateTime.Parse(endDate);
                if (previousWeekStart > end)
                {
                    acceptable = false;
                }

            }
            
            return acceptable;
        }



        

        //Variables.SettingsInstance
        public void setTeamDays(string days)
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
            
            this.TeamDays1 = Convert.ToInt32(days);
            Variables.SettingsInstance.TeamWeeks = this.TeamDays1;
            Variables.db.UpdateSettings(Variables.SettingsInstance);
            this.TeamDays2 = 2*this.TeamDays1;

        }
        public void setMemberDays(string days)
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

            this.MembersDays1 = Convert.ToInt32(days);
            this.MembersDays2 = 2 * this.MembersDays1;
            Variables.SettingsInstance.MembersDays = MembersDays1;
            Variables.db.UpdateSettings(Variables.SettingsInstance);
        }
    }
}

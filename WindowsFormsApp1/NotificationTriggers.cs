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

        public void CommitTrigger(Team aTeam)
        {
            foreach (TeamMembers item in Variables.db.GetMembers())
            {

                if (item.TeamName == aTeam.Name)
                {
                    if (commitHistoryDate(aTeam.Url, MembersDays1))
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
        /**
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


        public Boolean DismissCheckForCommit(DateTime date)
        {
            Boolean dismiss = false;
            DateTime today = DateTime.Today;
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




        public void setTeamDays(string days)
        {
            this.TeamDays1 = Convert.ToInt32(days);
            this.TeamDays2 = 2*this.TeamDays1;
        }
        public void setMemberDays(string days)
        {
            this.MembersDays1 = Convert.ToInt32(days);
            this.MembersDays2 = 2 * this.MembersDays1;
        }
    }
}

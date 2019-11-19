using System;
using System.Collections.Generic;
using System.Linq;
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

        public void CommitTrigger(TeamMembers aMember, int lastCommit,int days)
        {
            if (days<lastCommit)
            {
                aMember.CommitNotification = true;
                //more code to make it apper
            }
            else
            {
                aMember.CommitNotification = false;
                //dissmiss notification
            }
        }
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
        public Boolean commitHistoryDate (string url, int numberOfDays)         {              Boolean acceptable = true;             List<DateTime> dates = new List<DateTime>();             List<string> datesText = Variables.parseInstance.LoadGithubDataAsync(Variables.parseInstance.URLFactory(url, "commit"), "date");             foreach (var date in datesText)             {                 DateTime dateTime = DateTime.Parse(date);                 dates.Add(dateTime);             }             dates.Sort();             DateTime today = DateTime.Today;             DateTime daysAgo = today.AddDays(-numberOfDays);             int datesCount = dates.Count;             //acceptable = DateTime.Compare(daysAgo, dates[datesCount - 1]);             if (daysAgo > dates[datesCount - 1])             {                 acceptable = false;             }                  return acceptable;         }   

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

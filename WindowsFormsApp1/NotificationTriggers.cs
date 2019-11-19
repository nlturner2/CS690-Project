using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class NotificationTriggers
    {
        int TeamDays1 = 7;
        int TeamDays2 = 14;
        int MembersDays1 = 7;
        int MembersDays2 = 14;

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class NotificationTriggers
    {
        int TeamDays1 = 7;
        int TeamDays2 = 14;
        int MembersDays1 = 7;
        int MembersDays2 = 14;

        public NotificationTriggers()
        {

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

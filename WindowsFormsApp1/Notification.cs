using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Notification
    {
        public Variables Callingform { get; set; }
        
        int x =Variables.db.CountTeams();

        public void loadNoitification(HomeDashboard hd)
        {
            TeamMeeting(hd);
            TeamCommit(hd);
            TeamMemberCommit(hd);
        }

        public void loadNoitification(Team_Dashboard hd)
        {
            TeamMemberCommit(hd);
        }



        // creates notification for Team Meeting if the team does not meet
        public void TeamMeeting(HomeDashboard hd)
        {

            NotificationButton a = new NotificationButton();

            hd.Notification_Table.Controls.Add(a.createNotificationButton("teamMeeting"));
            hd.Notification_Table.Show();
            
        }

        // creates notification for commit if the whole team does not commit
        public void TeamCommit(HomeDashboard hd)
        {

            NotificationButton b = new NotificationButton();

            hd.Notification_Table.Controls.Add(b.createNotificationButton("teamCommit"));
            hd.Notification_Table.Show();
        }

        // creates notification if a team member does not commit
        public void TeamMemberCommit(HomeDashboard hd)
        {
            NotificationButton c = new NotificationButton();

            hd.Notification_Table.Controls.Add(c.createNotificationButton("memberCommit"));
            hd.Notification_Table.Show();
        }

        public void TeamMemberCommit(Team_Dashboard hd)
        {
            NotificationButton d = new NotificationButton();
            
            hd.Notification_Table2.Controls.Add(d.createNotificationButton("memberCommit"));
            d.closeButton.Click += new EventHandler(d.closeButton_Click2);
            hd.Notification_Table2.Show();
        }
        

    }
}

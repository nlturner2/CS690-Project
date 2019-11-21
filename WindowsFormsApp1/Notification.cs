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

        

        

        public void loadNotification(HomeDashboard hd,Triggers t)
        {

            //TeamMeeting(hd);
            //TeamCommit(hd);
            //TeamMemberCommit(hd);
            
            //IList<Triggers> trigger = Variables.db.GetTriggers();
            //foreach (Triggers i in trigger)
            //{
                if (t.Type == "teamMeeting")
                {
                    TeamMeeting(hd, t);
                }
                else if (t.Type == "teamCommit")
                {
                    TeamCommit(hd, t);
                }
                /*
                else if (t.Type == "memberCommit")
                {
                    TeamMemberCommit(hd, t);
                }
                */
            //}

        }

        public void loadNoitification(Team_Dashboard hd, Triggers t)
        {
            IList<Triggers> trigger = Variables.db.GetTriggers();
            //foreach (Triggers i in trigger)
            //{
                if (t.Type == "memberCommit")
                {
                    TeamMemberCommit(hd, t);
                }
            //}
        }



        // creates notification for Team Meeting if the team does not meet
        public void TeamMeeting(HomeDashboard hd, Triggers x)
        {

            NotificationButton a = new NotificationButton();

            hd.Notification_Table.Controls.Add(a.createNotificationButton(x));
            hd.Notification_Table.Show();
            
        }

        // creates notification for commit if the whole team does not commit
        public void TeamCommit(HomeDashboard hd, Triggers x)
        {

            NotificationButton b = new NotificationButton();

            hd.Notification_Table.Controls.Add(b.createNotificationButton(x));
            hd.Notification_Table.Show();
        }

        // creates notification if a team member does not commit
        
        /*public void TeamMemberCommit(HomeDashboard hd, Triggers x)
        {
            NotificationButton c = new NotificationButton();

            hd.Notification_Table.Controls.Add(c.createNotificationButton(x));
            hd.Notification_Table.Show();
        }
        */
        public void TeamMemberCommit(Team_Dashboard hd,Triggers x)
        {
            NotificationButton d = new NotificationButton();
            
            hd.Notification_Table2.Controls.Add(d.createNotificationButton(x));
            //d.closeButton.Click += new EventHandler(d.closeButton_Click2);
            hd.Notification_Table2.Show();
        }
        

    }
}

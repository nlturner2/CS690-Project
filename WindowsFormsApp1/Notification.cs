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

        IList<Triggers> trig = Variables.db.GetTriggers();

        public void loadNotification(HomeDashboard hd)
        {
            
            TeamMeeting(hd);
            TeamCommit(hd);
            TeamMemberCommit(hd);
           // IList<Triggers> trig = Variables.db.GetTriggers();
            foreach (Triggers i in trig)
            {
                if (i.Type == "teamMeeting")
                {
                    TeamMeeting(hd);
                }
                else if (i.Type == "teamCommit")
                {
                    TeamCommit(hd);
                }
                else if (i.Type == "memberCommit")
                {
                    TeamMemberCommit(hd);
                }
            }

        }

        public void loadNoitification(Team_Dashboard hd)
        {
            TeamMemberCommit(hd);
        }



        // creates notification for Team Meeting if the team does not meet
        public void TeamMeeting(HomeDashboard hd)
        {

            NotificationButton a = new NotificationButton();

            hd.Notification_Table.Controls.Add(a.createNotificationButton(trig));
            hd.Notification_Table.Show();
            
        }

        // creates notification for commit if the whole team does not commit
        public void TeamCommit(HomeDashboard hd)
        {

            NotificationButton b = new NotificationButton();

            hd.Notification_Table.Controls.Add(b.createNotificationButton(trig));
            hd.Notification_Table.Show();
        }

        // creates notification if a team member does not commit
        public void TeamMemberCommit(HomeDashboard hd)
        {
            NotificationButton c = new NotificationButton();

            hd.Notification_Table.Controls.Add(c.createNotificationButton(trig));
            hd.Notification_Table.Show();
        }

        public void TeamMemberCommit(Team_Dashboard hd)
        {
            NotificationButton d = new NotificationButton();
            
            hd.Notification_Table2.Controls.Add(d.createNotificationButton(trig));
            d.closeButton.Click += new EventHandler(d.closeButton_Click2);
            hd.Notification_Table2.Show();
        }

        public void removeNotification(Triggers t, Button x)
        {
            Variables.db.UpdateTriggers(t, false);

            Application.OpenForms.OfType<HomeDashboard>().First().Notification_Table.Controls.Remove(x);
            //Variables.db.UpdateTriggerDismiss()
        }

        public void removeNotificationMember(Triggers t, Button x)
        {
            Variables.db.UpdateTriggers(t, false);
            Application.OpenForms.OfType<Team_Dashboard>().First().Notification_Table2.Controls.Remove(x);
        }


    }
}

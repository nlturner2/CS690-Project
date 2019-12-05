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

        // loads notifications for the teams in the Home Dashboard
        public void loadNotification(HomeDashboard hd,Triggers t)
        {
                if (t.Type == "teamMeeting")
                {
                    TeamMeeting(hd, t);
                }
                else if (t.Type == "teamCommit")
                {
                    TeamCommit(hd, t);
                }
                else if (t.Type == "standard")
                {
                    FollowingStandard(hd, t);
                }
        }

        // loads notification for the team members in the Team Dashboard
        public void loadNoitification(Team_Dashboard hd, Triggers t)
        {
            IList<Triggers> trigger = Variables.db.GetTriggers();
                if (t.Type == "memberCommit")
                {
                    TeamMemberCommit(hd, t);
                }
        }

        // creates notification for Team Meeting if the team does not meet
        public void TeamMeeting(HomeDashboard hd, Triggers x)
        {
            NotificationButton a = new NotificationButton();
            hd.Notification_Table.Controls.Add(a.createNotificationButton(x));
            hd.Notification_Table.Show();
            

            foreach (Button tb in hd.tableLayoutPanel1.Controls)
            {
                if (tb.Text == x.TeamName)
                {

                    if (tb.Image == null)
                    {
                        tb.Image = WindowsFormsApp1.Properties.Resources.team5;
                        tb.ImageAlign = ContentAlignment.TopRight;
                    }

                    else if (tb.Image != null)
                    {
                        tb.Image = WindowsFormsApp1.Properties.Resources.both;
                        tb.ImageAlign = ContentAlignment.TopRight;
                    }
                }
            }

        }

        // creates notification for not following the standards
        public void FollowingStandard(HomeDashboard hd, Triggers x)
        {
            NotificationButton a = new NotificationButton();
            hd.Notification_Table.Controls.Add(a.createNotificationButton(x));
            hd.Notification_Table.Show();


            foreach (Button tb in hd.tableLayoutPanel1.Controls)
            {
                if (tb.Text == x.TeamName)
                {

                    if (tb.Image == null)
                    {
                        tb.Image = WindowsFormsApp1.Properties.Resources.standardIcon;
                        tb.ImageAlign = ContentAlignment.TopRight;
                    }

                    else if (tb.Image != null)
                    {
                        tb.Image = WindowsFormsApp1.Properties.Resources.both;
                        tb.ImageAlign = ContentAlignment.TopRight;
                    }
                }
            }
        }

        // creates notification for commit if the whole team does not commit
        public void TeamCommit(HomeDashboard hd, Triggers x)
        {
            NotificationButton b = new NotificationButton();
            hd.Notification_Table.Controls.Add(b.createNotificationButton(x));
            hd.Notification_Table.Show();

            foreach (Button tb in hd.tableLayoutPanel1.Controls)
            {
                if (tb.Text == x.TeamName)
                {   
                    if(tb.Image == null) {
                        tb.Image = WindowsFormsApp1.Properties.Resources.commit4;
                        tb.ImageAlign = ContentAlignment.TopRight;
                    }

                    else if (tb.Image != null)
                    {
                        tb.Image = WindowsFormsApp1.Properties.Resources.both;
                        tb.ImageAlign = ContentAlignment.TopRight;
                    }
                    
                }
            }
        }

        // creates notification if a team member does not commit
        public void TeamMemberCommit(Team_Dashboard hd,Triggers x)
        {
            NotificationButton d = new NotificationButton();
            hd.Notification_Table2.Controls.Add(d.createNotificationButton(x));
            d.closeButton.Click += (sender, EventArgs) => { d.closeButton_Click2(sender, EventArgs, x); };
            hd.Notification_Table2.Show();
        }
    }
}

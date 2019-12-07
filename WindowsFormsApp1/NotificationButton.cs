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
    class NotificationButton
    {
        public Variables Callingform { get; set; }
        public Button notiButton;
        public Button closeButton;
        public Button createNotificationButton(Triggers x)
        {
            notiButton = new Button();
            closeButton = new Button();
            notiButton.Size = new Size(540, 600);
            closeButton.Size = new Size(20, 20);
            closeButton.Image = WindowsFormsApp1.Properties.Resources.close5;
            closeButton.Location = new Point(238, 0);
            notiButton.Controls.Add(closeButton);            
            string s = x.Type;

            if (s == "teamMeeting")
            {
                string teamName = x.TeamName;
                notiButton.Text = "      " + teamName + " did not meet";
                notiButton.TextAlign = ContentAlignment.MiddleLeft;
                notiButton.Image = WindowsFormsApp1.Properties.Resources.team5;
                notiButton.ImageAlign = ContentAlignment.MiddleLeft;
                closeButton.Click += (sender, EventArgs) => { closeButton_Click(sender, EventArgs, x, Application.OpenForms.OfType<HomeDashboard>().First()); };

            }
            else if (s == "teamCommit")
            {
                string teamName = x.TeamName;
                notiButton.Text =  "       "+teamName + " did not commit";
                notiButton.TextAlign = ContentAlignment.MiddleLeft;
                notiButton.Image = WindowsFormsApp1.Properties.Resources.commit4;
                notiButton.ImageAlign = ContentAlignment.MiddleLeft;
                closeButton.Click += (sender, EventArgs) => { closeButton_Click(sender, EventArgs, x, Application.OpenForms.OfType<HomeDashboard>().First()); };
            }
            else if (s == "standard")
            {
                string teamName = x.TeamName;
                notiButton.Text = "       " + teamName + " not following standards";
                notiButton.TextAlign = ContentAlignment.MiddleLeft;
                notiButton.Image = WindowsFormsApp1.Properties.Resources.standardIcon;
                notiButton.ImageAlign = ContentAlignment.MiddleLeft;
                closeButton.Click += (sender, EventArgs) => { closeButton_Click(sender, EventArgs, x, Application.OpenForms.OfType<HomeDashboard>().First()); };
            }
            else if (s == "memberCommit")
            {
                string memberName = x.MemberName;
                notiButton.Text = "       "+ x.MemberName + " did not commit";
                notiButton.TextAlign = ContentAlignment.MiddleLeft;
                notiButton.Image = WindowsFormsApp1.Properties.Resources.memberCommit2;
                notiButton.ImageAlign = ContentAlignment.MiddleLeft;
                closeButton.Click += (sender, EventArgs) => { closeButton_Click2(sender, EventArgs, x); };
            }
            
            return notiButton;
        }

        // click method for close button of team notifications on HomeDahboard
        public void closeButton_Click(object sender, EventArgs e, Triggers t, HomeDashboard hd)
        {
            removeNotification(t);

            foreach (Button tb in hd.tableLayoutPanel1.Controls)
            {
                if (tb.Text == t.TeamName)
                {
                    tb.Image = null;

                    Application.OpenForms.OfType<HomeDashboard>().First().Notification_Table.Controls.Clear();

                    Application.OpenForms.OfType<HomeDashboard>().First().DisplayNotifications();
                }
            }
        }
        // click method for close button of team member notifications on Team_Dashboard
        public void closeButton_Click2(object sender, EventArgs e, Triggers t)
        {
            removeNotificationMember(t);
        }

        // removes notification from Home Dashboard
        public void removeNotification(Triggers trig)
        {
            Variables.db.UpdateTriggerDismiss(trig, DateTime.Today);
            Variables.db.UpdateTriggers(trig, false);
            Application.OpenForms.OfType<HomeDashboard>().First().Notification_Table.Controls.Remove(notiButton);
        }

        // removes notification from Team Dashboard
        public void removeNotificationMember(Triggers trig)
        {
            Variables.db.UpdateTriggerDismiss(trig, DateTime.Today);
            Variables.db.UpdateTriggers(trig, false);
            Application.OpenForms.OfType<Team_Dashboard>().First().Notification_Table2.Controls.Remove(notiButton);
        }
    }
}

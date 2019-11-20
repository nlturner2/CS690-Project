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
            //closeButton.Click += new EventHandler(closeButton_Click);

            IList<Triggers> trig = Variables.db.GetTriggers();
            Triggers test = new Triggers("asd");


            string s = x.Type;

            if (s == "teamMeeting")
            {
                string teamName = x.TeamName;
                notiButton.Text = "    Team did not meet";
                notiButton.TextAlign = ContentAlignment.MiddleLeft;
                notiButton.Image = WindowsFormsApp1.Properties.Resources.team5;
                notiButton.ImageAlign = ContentAlignment.MiddleLeft;
                closeButton.Click += new EventHandler(closeButton_Click(null, null, trig));

                Variables.db.UpdateTriggers(x, true);

            }

            else if (s == "teamCommit")
            {
                string teamName = x.TeamName;
                notiButton.Text = "     Team did not commit";
                notiButton.TextAlign = ContentAlignment.MiddleLeft;
                notiButton.Image = WindowsFormsApp1.Properties.Resources.commit3;
                notiButton.ImageAlign = ContentAlignment.MiddleLeft;
                closeButton.Click += new EventHandler(closeButton_Click(null, null, trig));
                Variables.db.UpdateTriggers(x, true);
            }

            else if (s == "memberCommit")
            {
                
                notiButton.Text = "     Team member did not commit";
                notiButton.TextAlign = ContentAlignment.MiddleLeft;
                notiButton.Image = WindowsFormsApp1.Properties.Resources.memberCommit2;
                notiButton.ImageAlign = ContentAlignment.MiddleLeft;
                closeButton.Click += new EventHandler(closeButton_Click2(null, null, trig));
                Variables.db.UpdateTriggers(x, true);
            }

            return notiButton;

        }

        // click method for notifications on HomeDahboard
        public void closeButton_Click(object sender, EventArgs e, Triggers trig)
        {
            //Button button = sender as Button;
            removeNotification(trig.TeamName());

            
        }

        // click method for notifications of team members on Team_Dashboard
        public void closeButton_Click2(object sender, EventArgs e, Triggers trig)
        {
            //Button button = sender as Button;
         
            removeNotificationMember(trig.);
        }

        public void removeNotification(Team t)
        {
            Variables.db.UpdateTriggers(t, false);

            Application.OpenForms.OfType<HomeDashboard>().First().Notification_Table.Controls.Remove(notiButton);
            //Variables.db.UpdateTriggerDismiss()
        }

        public void removeNotificationMember(TeamMembers t)
        {
            Variables.db.UpdateTriggers(t, false);
            Application.OpenForms.OfType<Team_Dashboard>().First().Notification_Table2.Controls.Remove(notiButton);
        }

    }
}

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
        public Button createNotificationButton(string s)
        {
            notiButton = new Button();
            closeButton = new Button();
            notiButton.Size = new Size(540, 600);
            closeButton.Size = new Size(20, 20);
            closeButton.Image = WindowsFormsApp1.Properties.Resources.close5;
            closeButton.Location = new Point(238, 0);
            notiButton.Controls.Add(closeButton);
            closeButton.Click += new EventHandler(closeButton_Click);
            


            if (s == "teamMeeting")
            {
                notiButton.Text = "     Team did not meet";
                notiButton.TextAlign = ContentAlignment.MiddleLeft;
                notiButton.Image = WindowsFormsApp1.Properties.Resources.team5;
                notiButton.ImageAlign = ContentAlignment.MiddleLeft;
            }

            else if (s == "teamCommit")
            {
                notiButton.Text = "     Team did not commit";
                notiButton.TextAlign = ContentAlignment.MiddleLeft;
                notiButton.Image = WindowsFormsApp1.Properties.Resources.commit3;
                notiButton.ImageAlign = ContentAlignment.MiddleLeft;
            }

            else if (s == "memberCommit")
            {
                notiButton.Text = "     Team member did not commit";
                notiButton.TextAlign = ContentAlignment.MiddleLeft;
                notiButton.Image = WindowsFormsApp1.Properties.Resources.memberCommit2;
                notiButton.ImageAlign = ContentAlignment.MiddleLeft;
            }

            return notiButton;

        }

        // click method for notifications on HomeDahboard
        private void closeButton_Click(object sender, EventArgs e)
        {
            //Button button = sender as Button;
            removeNotification();

            
        }

        // click method for notifications on Team_Dashboard
        public void closeButton_Click2(object sender, EventArgs e)
        {
            //Button button = sender as Button;
         
            removeNotificationTd();
        }

        public void removeNotification()
        {
            Application.OpenForms.OfType<HomeDashboard>().First().Notification_Table.Controls.Remove(notiButton);
            Variables.db.
        }

        public void removeNotificationTd()
        {
            Application.OpenForms.OfType<Team_Dashboard>().First().Notification_Table2.Controls.Remove(notiButton);
        }

    }
}

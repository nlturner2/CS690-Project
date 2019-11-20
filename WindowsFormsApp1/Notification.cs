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
        private DataConnection DB = new DataConnection();
        public void loadNoitification(HomeDashboard hd)
        {
            TeamMeeting(hd);
            TeamCommit(hd);
            TeamMemberCommit(hd);
        }
        // creates notification for Team Meeting if the team does not meet
        public void TeamMeeting(HomeDashboard hd)
        {
            Button a = createNotiButton("teamMeeting");   
            hd.Notification_Table.Controls.Add(a);
            hd.Notification_Table.Show();   
        }
        // creates notification for commit if the whole team does not commit
        public void TeamCommit(HomeDashboard hd)
        {
            Button b = createNotiButton("teamCommit");
            hd.Notification_Table.Controls.Add(b);
            hd.Notification_Table.Show();
        }
        // creates notification if a team member does not commit
        public void TeamMemberCommit(HomeDashboard hd)
        {
            Button c = createNotiButton("memberCommit");
            hd.Notification_Table.Controls.Add(c);
            hd.Notification_Table.Show();
        }
        // method for creating notification button
       public Button createNotiButton(string s)
        {
            Button notiButton = new Button();
            Button closeButton = new Button();
            notiButton.Size = new Size(540, 600);
            closeButton.Size = new Size(20, 20);
            closeButton.Image = WindowsFormsApp1.Properties.Resources.close5;
            closeButton.Location = new Point(238, 0);
            notiButton.Controls.Add(closeButton);
            if (s == "teamMeeting")
            {
                notiButton.Text = "     Team did not meet";
                notiButton.TextAlign = ContentAlignment.MiddleLeft;
                notiButton.Image = WindowsFormsApp1.Properties.Resources.team5;
                notiButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
            else if(s == "teamCommit")
            {
                notiButton.Text = "     Team did not commit";
                notiButton.TextAlign = ContentAlignment.MiddleLeft;
                notiButton.Image = WindowsFormsApp1.Properties.Resources.commit3;
                notiButton.ImageAlign = ContentAlignment.MiddleLeft;
            } 
            else if(s == "memberCommit")
            {
                notiButton.Text = "     Team member did not commit";
                notiButton.TextAlign = ContentAlignment.MiddleLeft;
                notiButton.Image = WindowsFormsApp1.Properties.Resources.memberCommit2;
                notiButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
            return notiButton;
        }
    }
}

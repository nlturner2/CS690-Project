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
    class Notification
    {
        //HomeDashboard hd = new HomeDashboard();
        private DataConnection DB = new DataConnection();
        Button notiButton = new Button();
        Button closeButton = new Button();

        public Notification()
        {
            notiButton.Size = new Size(540, 50);
            closeButton.Size = new Size(35, 35);
        }
        public void TeamMeeting(HomeDashboard hd)
        {

            hd.Notification_Table.Controls.Add(notiButton);
            hd.Notification_Table.Show();
            
        }

        public void TeamCommit()
        {

        }

        public void TeamMemberCommit()
        {

        }


    }
}

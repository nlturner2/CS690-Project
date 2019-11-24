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
    public class Team
    {
        private string name;
        private string url;
        


        public Team()
        {
            
        }

        public Team(String n, String u)
        {
            name = n;
            url = u;
            //MeetingNotification = false;
            
        }

        

        public int Id { get; set; }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Url
        {
            get { return url; }
            set { url = value; }
        }
        

        internal static bool isNull(Team[] tempTeam)
        {
            throw new NotImplementedException();
        }
    }
}



 
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
    public class TeamButton
    {
        
        private Button button;

        public TeamButton(Team s)
        {
            button = new Button();
            button.Text = s.Name;
            button.Size = new Size(540, 50);
            

        }

        public String Text
        {
            get { return Text; }
            set { Text = value; }
        }

        public Button getButton()
        {
            return button;
        }

       

    }
}

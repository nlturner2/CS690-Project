using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Team
    {
        private String name;
        private String url;
        private Button button;

        
        public Team()
        {
            button = new Button();
            button.Size = new Size(540, 50);

        }

        public Team(String n, String u)
        {
            name = n;
            url = u;
            button = new Button();
            button.Text = n;
            button.Size = new Size(540, 50);
        }

        public Button getButton()
        {
            return button;
        }

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

        public override string ToString()
        {
            return "Person: " + name + " " + url;
        }

    }
}

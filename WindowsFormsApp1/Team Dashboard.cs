using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Team_Dashboard : Form
    {
        public Team_Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            StreamReader file =new StreamReader(@"C:\CapstoneProjectTemplate-master\CapstoneProjectTemplate-master\Hello.txt");
            while((line = file.ReadLine()) != null)
            {

                Console.WriteLine(line);
                counter++;
            }
            file.Close();
            Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            Console.ReadLine();
        }
    }
}
            

        

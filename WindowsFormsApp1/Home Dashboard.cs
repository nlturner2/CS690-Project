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
    public partial class HomeDashboard : Form
    {
        public HomeDashboard()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            //HomeDashboard TL = new HomeDashboard();
            var f2 = new Add_Team();
            f2.Show();
            //.button1_Click(f2, e);
            f2.createTeam(this);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            var f2 = new Remove_Team();
            f2.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Team_Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void TeamDashboard_Load(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {

        }

        private void Notifications_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
    
}

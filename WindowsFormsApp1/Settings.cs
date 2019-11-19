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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void SaveTeam_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void SaveMembers_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Members_TextChanged(object sender, EventArgs e)
        {
            var TM = this.MembersBox.Text.Insert(this.MembersBox.SelectionStart, "0");


        }

        private void Team_TextChanged(object sender, EventArgs e)
        {
            var TU = this.TeamBox.Text.Insert(this.TeamBox.SelectionStart, "0");
        }
    }
}

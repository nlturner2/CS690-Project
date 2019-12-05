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
        public Variables Callingform { get; set; }
        public Settings()
        {
            InitializeComponent();
            TeamBox.Text = Convert.ToString(Variables.SettingsInstance.TeamWeeks);
            MembersBox.Text = Convert.ToString(Variables.SettingsInstance.MembersDays);
        }
        private void SaveTeam_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(TeamBox.Text, out value)  && Convert.ToInt32(TeamBox.Text) > 0)
            {
                Variables.NTInstance.setTeamDays(TeamBox.Text);
            }
            else
            {
                MessageBox.Show("Number of weeks has to be greater than 0");
            }
        }
        private void SaveMembers_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(MembersBox.Text, out value) && Convert.ToInt32(MembersBox.Text) > 0)
            {
                Variables.NTInstance.setMemberDays(MembersBox.Text);
            }
            else
            {
                MessageBox.Show("Number of days has to be greater than 0");
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Members_TextChanged(object sender, EventArgs e)
        {
            var TM = this.MembersBox.Text.Insert(this.MembersBox.SelectionStart, "0");
        }
        private void Team_TextChanged(object sender, EventArgs e)
        {
            var TU = this.TeamBox.Text.Insert(this.TeamBox.SelectionStart, "0");
        }
        private void Settings_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
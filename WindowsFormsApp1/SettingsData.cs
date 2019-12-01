using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SettingsData
    {
        public SettingsData()
        {
            MembersDays = 7;
            TeamWeeks = 1;
        }
        public SettingsData(int tDays, int mDays)
        {
            MembersDays = mDays;
            TeamWeeks = tDays;
        }
        public int Id { get; set; }
        public int MembersDays { get; set; }
        public int TeamWeeks { get; set; }
    }
}

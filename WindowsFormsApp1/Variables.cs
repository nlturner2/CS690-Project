using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Variables
    {
        public Variables Callingform { get; set; }
        private static TeamManagement TM = new TeamManagement();
        public static TeamManagement TMInstance
        {
            get => TM;

        }

        private static DataConnection dbc = new DataConnection();

        public static DataConnection db
        {
            get => dbc;
        }
        private static Parser parse = new Parser();
        public static Parser parseInstance
        {
            get => parse;
        }
        private static NotificationTriggers NT = new NotificationTriggers();
        public static NotificationTriggers NTInstance
        {
            get => NT;
        }
        private static Notes note = new Notes();
        public static Notes NotesInstance
        {
            get => note;
        }

        private static SettingsData Settings = new SettingsData();
        public static SettingsData SettingsInstance
        {
            get => Settings;

        }



    }



        
}

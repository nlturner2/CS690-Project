using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Variables
    {
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

    }


        
}

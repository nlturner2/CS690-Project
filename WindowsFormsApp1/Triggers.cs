using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Triggers
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string TeamName { get; set; }
        public Boolean Active { get; set; }
        public DateTime DismissDate { get; set; }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class TeamManagementTests
    {
        private static TeamManagement TM = new TeamManagement();
        Team team1 = new Team("team1", "x");
        Team team2 = new Team("team2", "y");
        Team team3 = new Team("team3", "z");

        [TestMethod]
        public void WriteTest()
        {
            TM.Write(team1);
            Assert.AreEqual("team1" , TM.teamBook[0].Name);
        }
        [TestMethod]
        public void WriteTest1()
        {
            Assert.AreEqual("x", TM.teamBook[0].Url);
        }
    }
}
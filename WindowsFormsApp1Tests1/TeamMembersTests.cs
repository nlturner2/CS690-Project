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
    public class TeamMembersTests
    {
        TeamMembers bob = new TeamMembers("bob","Team1");
        [TestMethod()]
        public void TeamMembersTest()
        {
            Assert.AreEqual("bob", bob.MemberName);
        }

        [TestMethod()]
        public void TeamMembersTest1()
        {
            Assert.AreEqual("Team1", bob.TeamName);
        }
        [TestMethod()]
        public void TeamMembersTest2()
        {
            bob.MemberName = "bobby";
            Assert.AreEqual("bobby", bob.MemberName);
        }

        [TestMethod()]
        public void TeamMembersTest3()
        {
            bob.TeamName = "Team2";
            Assert.AreEqual("Team2", bob.TeamName);
        }
    }
}
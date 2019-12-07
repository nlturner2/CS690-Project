using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1Tests1
{
    [TestClass]
    public class UnitTest1
    {
        private Parser parser = new Parser();

        [TestMethod]
        public void fileNameSortingTest()
        {

            List<string> filenameList = new List<string>();
            string t1 = "09-01-2019_09-07-2019.md";
            string t2 = "10-01-2019_10-07-2019.md";
            string t3 = "08-10-2019_08-17-2019.md";
            string t4 = "07-01-2019_07-07-2019.md";
            string t5 = "MeetingTemplate.md";
            filenameList.Add(t1);
            filenameList.Add(t2);
            filenameList.Add(t3);
            filenameList.Add(t4);
            filenameList.Add(t5);

            var list = parser.fileNameSorting(filenameList);

            Assert.AreEqual(t2,list[0]);
            Assert.AreEqual(t1, list[1]);
            Assert.AreEqual(t3, list[2]);
            Assert.AreEqual(t4, list[3]);
            Assert.AreEqual(t5, list[4]);
        }

    }
}

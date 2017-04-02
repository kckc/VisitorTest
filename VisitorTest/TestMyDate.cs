using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorTest
{
    [TestClass]
    public class TestMyDate
    {
        [TestMethod]
        public void TestPrintConstructor_Print_ExpectCorrectString()
        {
            MyDate d = new MyDate(1, 1, 1);

            string outStr = RunWithConsoleRouteToString(() =>
            {
                d.PrintConstructor();
            });

            string expected = @"new MyDate(1, 1, 1)
";

            Assert.AreEqual(expected, outStr);
        }

        [TestMethod]
        public void TestMyDateAccept_VisitWithVisitor_ExpectCorrectString()
        {
            MyDate d = new MyDate(1, 1, 1);
            
            string outStr = RunWithConsoleRouteToString(() =>
            {
                ((IVisitable)d).accept(new MyVisitor());
            });

            string expected = @"new MyDate(1, 1, 1)
";

            Assert.AreEqual(expected, outStr);
        }

        private string RunWithConsoleRouteToString(Action action)
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                action();

                string outString = sw.ToString();

                return outString;
            }
        }
    }
}

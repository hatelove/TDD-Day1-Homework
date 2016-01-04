using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListAdder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ListAdder.Tests
{
    [TestClass()]
    public class ListAdderTests
    {
        MyTable table;

        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            Console.WriteLine("ClassInitialize" + testContext.TestName);
        }
        
        [TestInitialize()]
        public void MyTestInitialize()
        {
            Console.WriteLine("TestInitialize");
            table = new MyTable();
            table.AddColumn("Id", new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });
            table.AddColumn("Cost", new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });
            table.AddColumn("Revenue", new List<int>() { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 });
            table.AddColumn("SellPrice", new List<int>() { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 });
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            Console.WriteLine("TestCleanup");
        }

        [TestMethod()]
        public void SigmaTest_Cost_group_by_3()
        {
            var la = new ListAdder();
            var expected = new List<int>() { 6, 15, 24, 21 };
            var actual = la.Sigma(table, "Cost", 3);
            CollectionAssert.AreEqual(expected, actual);	
        }

        [TestMethod()]
        public void SigmaTest_Revenue_group_by_4()
        {
            var la = new ListAdder();
            var expected = new List<int>() { 50, 66, 60 };
            var actual = la.Sigma(table, "Revenue", 4);
            CollectionAssert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(System.Collections.Generic.KeyNotFoundException))]
        [TestMethod()]
        public void SigmaTest_Empty_group_by_1()
        {
            var la = new ListAdder();
            var expected = new List<int>();
            var actual = la.Sigma(table, "Empty", 1);
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}

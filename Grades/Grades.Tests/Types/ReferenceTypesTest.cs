using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Grades.Tests.Types
{
    [TestClass]
    class ReferenceTypesTest
    {
        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Vladi";
            string name2 = "vladi";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCulture);
            Assert.IsTrue(result);
        }
        //[TestMethod]
        //public void IntVariableHoldsValue()
        //{
        //    int x1 = 100;
        //    int x2 = x1;

        //    x1 = 4;
        //    Assert.AreNotEqual(x1, x2);
        //}

        //[TestMethod]
        //public void VariableHoldReference()
        //{
        //    GradeBook g1 = new GradeBook();
        //    GradeBook g2 = g1;   

        //    g1.Name = "Vladi grades";
        //    Assert.AreEqual(g1.Name, g2.Name);
        //}
    }
}

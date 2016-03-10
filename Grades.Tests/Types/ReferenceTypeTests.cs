using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {

        [TestMethod]
        public void UpperCaseString()
        {
            string name = "jim";
            name = name.ToUpper();

            Assert.AreEqual("JIM", name);


        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2016, 1, 1);
            
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);
            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            Gradebook book1 = new Gradebook();
            Gradebook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A Gradebook", book1.Name);
        }

        private void GiveBookAName(Gradebook book)
        {
            book.Name = "A Gradebook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Jim";
            string name2 = "jim";

            bool result = string.Equals(name1, name1, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            // = 4;
            Assert.AreEqual(x1, x2);
       }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            Gradebook g1 = new Gradebook();
            Gradebook g2 = g1;

            g1.Name = "Jims new gradebook!";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}

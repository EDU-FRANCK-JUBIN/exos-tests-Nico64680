using System;
using exo_tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace exo_test.test
{
    [TestClass]
    public class ClassTest
    {
        [TestMethod]
        public void ValidParameters()
        {
            string initiale = ClasseChaine.RetourneInitiales("Nicolas", "FERREIRA");
            Assert.AreEqual(initiale, "NF");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BadParameters()
        {
            ClasseChaine.RetourneInitiales(null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BadParameters2()
        {
            ClasseChaine.RetourneInitiales("Nicolas", null);
        }

        [TestMethod]
        public void MultipleName()
        {
            string initiale = ClasseChaine.RetourneInitiales("Nicolas Jean", "FERREIRA AA");
            Assert.AreEqual(initiale, "NJFA");
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MagazynTEST.Magazyn;
using static MagazynTEST.Produkt;

namespace MagazynTEST
{
    public class MagazynTesty
    {
        [TestClass]
        public class MagazynTest()
        {
            [TestMethod]
            public void DodajProdukt1_ReturnCorrectResult_True1()
            {
                var magazyn = new Magazyn();
                bool result = magazyn.dodajProdukt("aa",12);
                Assert.IsTrue(result);
                int result1 = magazyn.sprawdzStan("aa");
                Assert.AreEqual(12, result1);
            }
            [TestMethod]
            public void DodajProdukt2_ReturnCorrectResult_True2()
            {
                var magazyn = new Magazyn();
                bool result = magazyn.dodajProdukt("aa", 12);
                Assert.IsTrue(result);
                bool result0 = magazyn.dodajProdukt("aa", 12);
                Assert.IsTrue(result);
                int result1 = magazyn.sprawdzStan("aa");
                Assert.AreEqual(24, result1);
            }
            [TestMethod]
            public void DodajProdukt3_ReturnCorrectResult_False1()
            {
                var magazyn = new Magazyn();
                bool result = magazyn.dodajProdukt("aa", -12);
                Assert.IsFalse(result);
                int result1 = magazyn.sprawdzStan("aa");
                Assert.AreEqual(0, result1);
            }
            [TestMethod]
            public void DodajProdukt4_ReturnCorrectResult_False2()
            {
                var magazyn = new Magazyn();
                bool result = magazyn.dodajProdukt("aa", 0);
                Assert.IsFalse(result);
                int result1 = magazyn.sprawdzStan("aa");
                Assert.AreEqual(0, result1);
            }
            [TestMethod]
            public void DodajProdukt5_ReturnCorrectResult_False3()
            {
                var magazyn = new Magazyn();
                bool result = magazyn.dodajProdukt("", 12);
                Assert.IsFalse(result);
                int result1 = magazyn.sprawdzStan("");
                Assert.AreEqual(0, result1);
            }
            [TestMethod]
            public void ZdejmijProdukt1_ReturnCorrectResult_True1()
            {
                var magazyn = new Magazyn();
                bool result = magazyn.dodajProdukt("aa", 12);
                Assert.IsTrue(result);
                int result1 = magazyn.sprawdzStan("aa");
                Assert.AreEqual(12, result1);
                bool result2 = magazyn.zdejmijProdukt("aa", 10);
                Assert.IsTrue(result2);
                int result3 = magazyn.sprawdzStan("aa");
                Assert.AreEqual(2, result3);
            }
            [TestMethod]
            public void ZdejmijProdukt2_ReturnCorrectResult_True2()
            {
                var magazyn = new Magazyn();
                bool result = magazyn.dodajProdukt("aa", 12);
                Assert.IsTrue(result);
                int result1 = magazyn.sprawdzStan("aa");
                Assert.AreEqual(12, result1);
                bool result2 = magazyn.zdejmijProdukt("aa", 12);
                Assert.IsTrue(result2);
                int result3 = magazyn.sprawdzStan("aa");
                Assert.AreEqual(0, result3);
            }
            [TestMethod]
            public void ZdejmijProdukt3_ReturnCorrectResult_False1()
            {
                var magazyn = new Magazyn();
                bool result = magazyn.dodajProdukt("aa", 12);
                Assert.IsTrue(result);
                int result1 = magazyn.sprawdzStan("aa");
                Assert.AreEqual(12, result1);
                bool result2 = magazyn.zdejmijProdukt("aa", -12);
                Assert.IsFalse(result2);
                int result3 = magazyn.sprawdzStan("aa");
                Assert.AreEqual(12, result3);
            }
            [TestMethod]
            public void ZdejmijProdukt4_ReturnCorrectResult_False2()
            {
                var magazyn = new Magazyn();
                bool result = magazyn.dodajProdukt("aa", 12);
                Assert.IsTrue(result);
                int result1 = magazyn.sprawdzStan("aa");
                Assert.AreEqual(12, result1);
                bool result2 = magazyn.zdejmijProdukt("aa", 100);
                Assert.IsFalse(result2);
                int result3 = magazyn.sprawdzStan("aa");
                Assert.AreEqual(12, result3);
            }
            [TestMethod]
            public void ZdejmijProdukt5_ReturnCorrectResult_False3()
            {
                var magazyn = new Magazyn();
                bool result = magazyn.dodajProdukt("aa", 12);
                Assert.IsTrue(result);
                int result1 = magazyn.sprawdzStan("aa");
                Assert.AreEqual(12, result1);
                bool result2 = magazyn.zdejmijProdukt("bb", 100);
                Assert.IsFalse(result2);
                int result3 = magazyn.sprawdzStan("aa");
                Assert.AreEqual(12, result3);
                int result4 = magazyn.sprawdzStan("bb");
                Assert.AreEqual(0, result4);
            }
        }
    }
    
}

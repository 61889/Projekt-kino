using KinoRejestracja;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestyKinoLOL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var ob = new Form2("test");
            //Act
            var wynik = ob.funnyButtonsTest();
            //Assert
            Assert.AreEqual(wynik, 4);
        }
    }
}

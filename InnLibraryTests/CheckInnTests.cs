using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using InnLibrary;

namespace InnLibraryTests
{
    [TestClass]
    public class CheckInnTests
    {
        [DataTestMethod]
        [DataRow("500100732259")]
        [DataRow("825002039663")]
        [DataRow("663555067806")]
        [DataRow("128808228380")]
        [DataRow("112107486650")]

        public void CorrectFillINN(string innCode)
        {
            //Act
            bool actual = CheckInn.CorrectFillINN(innCode);

            //Arrange
            Assert.IsTrue(actual);
        }
      
    }
}

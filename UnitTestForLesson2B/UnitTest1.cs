using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_S2016_Lesson2B;

namespace UnitTestForLesson2B
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void addXandYTestMethod()
        {
            //Arrange
            int x = 40;
            int y = 50;
            int expectedResult = 90;

            //Act

            int result = Program.addXandY(x, y);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void addYtoXTestMethod()
        {
            //Arrange
            int x = 40;
            int y = 50;
            int expectedResult = 90;

            //Act

            int result = Program.addYtoX(ref x, ref y);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void readUntilEndTestMethod()
        {
            //Arrange
            int numberOfEnteries = 5;
            int expectedCount = 5;
            int actualCount = 0;
            //Act
            actualCount = Program.readUntilEnd(numberOfEnteries);
            
            //Assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserNamespace;

namespace MoodAnalyserMsTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// UC1 for Testcase1
        /// </summary>
        MoodAnalyser moodAnalyser;
        [DataRow("I am in sad mood")]
        [TestMethod]
        public void Testfunction(string message)
        {
            //Arrange
            moodAnalyser = new MoodAnalyser(message);
            //Act
            var actual = moodAnalyser.AnalyserMethod();
            //Assert
            Assert.AreEqual("SAD", actual);
        }
        /// <summary>
        /// UC1 for TC1.1
        /// </summary>
        /// <param name="message"></param>
        [DataRow("I am in any mood")]
        [TestMethod]
        public void Testfunctin(string message)
        {
            //Arrange
            moodAnalyser = new MoodAnalyser(message);
            //Act
            var actual = moodAnalyser.AnalyserMethod();
            //Assert
            Assert.AreEqual("HAPPY", actual);
        }

        /// <summary>
        /// UC2 for NullExceptions
        /// </summary>
        /// <param name="message"></param>
        [DataRow(null)]
        [TestMethod]
        public void GivenNullShouldReturnHappy(string message)
        {
            //arrange
            string expected = "HAPPY";
            moodAnalyser = new MoodAnalyser(message);
            //Act
            string mood = moodAnalyser.AnalyserMethod();
            //assert
            Assert.AreEqual(expected, mood);
        }
    }
}

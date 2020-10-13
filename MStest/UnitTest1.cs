using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserNamespace;
using TestReflections;

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
        /// TC 3.1 for NullExceptions
        /// </summary>
        /// <param name="message"></param>
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisCustomException_IndicatingEmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("mood should not be empty", e.Message);
            }

        }
        [TestMethod]
        public void Given_Null_Mood_Should_Throw_MoodAnalysisCustomException_IndicatingNullMood()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyserMethod();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("mood should not be null", e.Message);
            }

        }
    }
}

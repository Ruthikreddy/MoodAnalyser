using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserNamespace;
namespace MoodAnalyserMsTest
{
    [TestClass]
    public class UnitTest1
    {

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
            Assert.AreEqual("Sad", actual);
        }

        [DataRow("I am in any mood")]
        [TestMethod]
        public void Testfunctin(string message)
        {
            //Arrange
            moodAnalyser = new MoodAnalyser(message);
            //Act
            var actual = moodAnalyser.AnalyserMethod();
            //Assert
            Assert.AreEqual("Happy", actual);
        }
    }
}

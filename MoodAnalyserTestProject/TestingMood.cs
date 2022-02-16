using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblems;
namespace MoodAnalyserTestProject
{
    /// <summary>
    /// Different Test Cases For Analysing Mood
    /// </summary>
    [TestClass]
    public class TestingMood 
    {
        //Method to test sad message
        [TestCategory("SAD Message")]
        [TestMethod]
        public void GivenSadMessageReturnSadMood() 
        {
            ///AAA
            ///Arange
            string msg = "I am in SAD Mood";
            string expected = "sad";
            MoodAnalyser mood = new MoodAnalyser(msg);
            ///Act
            string actual = mood.AnalyseMood();
            ///Asert
            Assert.AreEqual(expected, actual);
        }
        //Method to test happy message
        [TestCategory("HAPPY Message")]
        [TestMethod]
        public void GivenHappyMessageReturnHappyMood() 
        {
            ///AAA
            ///Arange
            string msg = "I am in ANY Mood";
            string expected = "happy";
            MoodAnalyser mood = new MoodAnalyser(msg);
            ///Act
            string actual = mood.AnalyseMood();
            ///Asert
            Assert.AreEqual(expected, actual);
        }
    }
}
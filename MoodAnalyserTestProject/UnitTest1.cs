using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblems;
namespace MoodAnalyserTestProject
{// <summary>
    /// Different Test Cases For Analysing Mood
    /// </summary>
    [TestClass]
    public class MoodAnalyserTestClass 
    {
        //Method to test sad message(UC1-TC1.1)
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
        //Method to test happy message(UC1-TC1.2)
        [TestCategory("HAPPY Message")]
        [TestMethod]
        public void GivenAnyMessageReturnHappyMood() 
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
        //Method to test happy message(UC2-TC2.1)
        [TestCategory("Null Exception")]
        [TestMethod]
        public void GivenNullMessageException() 
        {
            ///AAA
            ///Arange
            string msg = null;
            string expected = "happy";
            //string actual = null;
            MoodAnalyser mood = new MoodAnalyser(msg);
            string actual = mood.AnalyseMood();
            ///Asert
            Assert.AreEqual(expected, actual);
        }
    }
}
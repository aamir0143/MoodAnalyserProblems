using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblems;
namespace MoodAnalyserTestProject
<<<<<<< HEAD
{// <summary>
    /// Different Test Cases For Analysing Mood
    /// </summary>
    [TestClass]
    public class TestingMood 
    {
<<<<<<< HEAD:MoodAnalyserTestProject/UnitTest1.cs
        //Method to test sad message(UC1-TC1.1)
=======
        //Method to test sad message
>>>>>>> UC1_HappyOrSadMood:MoodAnalyserTestProject/TestingMood.cs
        [TestCategory("SAD Message")]
        [TestMethod]
        public void GivenSadMessageReturnSadMood() 
=======
{
    /// <summary>
    /// Different Test Cases For Analysing Mood
    /// </summary>
    [TestClass]
    public class TestingMood
    {
        //Method to test sad message(UC1-TC1.1)
        [TestCategory("SAD Message")]
        [TestMethod]
        public void GivenSadMessageReturnSadMood()
>>>>>>> UC2_HandlingException
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
<<<<<<< HEAD
<<<<<<< HEAD:MoodAnalyserTestProject/UnitTest1.cs
        //Method to test happy message(UC1-TC1.2)
=======
        //Method to test happy message
>>>>>>> UC1_HappyOrSadMood:MoodAnalyserTestProject/TestingMood.cs
        [TestCategory("HAPPY Message")]
        [TestMethod]
        public void GivenAnyMessageReturnHappyMood() 
=======
        //Method to test happy message(UC1-TC1.2)
        [TestCategory("HAPPY Message")]
        [TestMethod]
        public void GivenHappyMessageReturnHappyMood() 
>>>>>>> UC2_HandlingException
        {
            ///AAA
            ///Arange
            string msg = "I am in ANY Mood";
            string expected = "happy";
            MoodAnalyser mood = new MoodAnalyser(msg);
            ///Act
            string actual = mood.AnalyseMood();
            ///Asert
<<<<<<< HEAD
<<<<<<< HEAD:MoodAnalyserTestProject/UnitTest1.cs
=======
>>>>>>> UC2_HandlingException
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
<<<<<<< HEAD
            //string actual = null;
            MoodAnalyser mood = new MoodAnalyser(msg);
            string actual = mood.AnalyseMood();
            ///Asert
=======
>>>>>>> UC1_HappyOrSadMood:MoodAnalyserTestProject/TestingMood.cs
=======
            MoodAnalyser mood = new MoodAnalyser(msg);
            //Act
            string actual = mood.AnalyseMood();
            ///Asert
>>>>>>> UC2_HandlingException
            Assert.AreEqual(expected, actual);
        }
    }
}
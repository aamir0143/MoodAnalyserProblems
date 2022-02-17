using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblems;
using System;
namespace MoodAnalyserTestProject
{
    /// <summary>
    /// Different Test Cases For Analysing Mood
    /// </summary>
    [TestClass]
    public class TestingMood
    {
        MoodAnalyser setMood, setMoodAny, setNull, setEmpty;
        MoodAnalyserReflector reflector;
        //Initializing the constructor
        [TestInitialize]
        public void SetUp()
        {
            string sadMessage = "I am in Sad Mood";
            setMood = new MoodAnalyser(sadMessage);
            string happyMessage = "I am in Any Mood";
            setMoodAny = new MoodAnalyser(happyMessage);
            string nullMessage = null;
            setNull = new MoodAnalyser(nullMessage);
            string emptyMessage = "";
            setEmpty = new MoodAnalyser(emptyMessage);
            reflector = new MoodAnalyserReflector();
        }
        //Method to test sad message(UC1-TC1.1)
        [TestCategory("SAD MESSAGE")]
        [TestMethod]
        public void GivenSadMessageReturnSadMood() 
        {
            ///AAA
            ///Arange        
            string expected = "sad";
            ///Act
            string actual = setMood.AnalyseMood();
            ///Asert
            Assert.AreEqual(expected, actual);
        }
        //Method to test happy message(UC1-TC1.2)
        [TestCategory("HAPPY MESSAGE")]
        [TestMethod]
        public void GivenHappyMessageReturnHappyMood() 
        {
            ///AAA
            ///Arange
            string expected = "happy";
            ///Act
            string actual = setMoodAny.AnalyseMood();
            ///Asert
            Assert.AreEqual(expected, actual);
        }
        //Method to test happy message(UC2-TC2.1)
        [TestCategory("NULL EXCEPTION")]
        [TestMethod]
        public void GivenNullMessageException() 
        {
            ///AAA
            ///Arange
            string expected = "happy";
            ///Act
            string actual = setNull.AnalyseMood();
            ///Asert
            Assert.AreEqual(expected, actual);
        }
        //Method to test custom exception message(UC3-TC3.1)
        [TestCategory("CUSTOM EXCEPTION")]
        [TestMethod]
        public void GivenCustomNullException() 
        {
            ///AAA
            ///Arange
            string expected = "Message should not be null";
            try
            {
                ///Act
                string actual = setNull.AnalyseMood();
            }
            catch (MoodAnalysisException e)
            {
                ///Asert
                Assert.AreEqual(expected, e.Message);
            }
        }
        //Method to test custom exception message(UC3-TC3.2)
        [TestCategory("CUSTOM EXCEPTION")]
        [TestMethod]
        public void GivenCustomEmptyException() 
        {
            ///AAA
            ///Arange
            string expected = "Message should not be empty";
            try
            {
                ///Act
                string actual = setEmpty.AnalyseMood();
            }
            catch (MoodAnalysisException e)
            {
                ///Asert
                Assert.AreEqual(expected, e.Message);
            }
        }
        //Method to test so moodanalyser class return moodanalyser objects(UC4-TC4.1)
        [TestCategory("REFLECTION")]
        [TestMethod]
        [DataRow("MoodAnalyserProblems.Customer", "Customer")]
        [DataRow("MoodAnalyserProblems.MoodAnalyser", "MoodAnalyser")]
        public void ReturnDefaultConstructor(string className, string constructor)
        {
            MoodAnalyser expected = new MoodAnalyser();
            object obj = null;
            try
            {
                obj = reflector.CreateMoodAnalyserObject(className, constructor);
            }
            catch (MoodAnalysisException ex)
            {
                throw new Exception(ex.Message);
            }
            expected.Equals(obj);
        }
        //Method to test so mood analyser with diff class to return no class found(UC4-TC4.2)
        [TestCategory("REFLECTION")]
        [TestMethod]
        [DataRow("MoodAnalyserProblems.Linklist", "Linklist", "The Given Class IS Not Found")]
        [DataRow("MoodAnalyserProblems.Stack", "Stack", "The Given Class IS Not Found")]
        public void ReturnDefaultConstructorNoClassFound(string className, string constructor, string expected)
        {
            object obj = null;
            try
            {
                obj = reflector.CreateMoodAnalyserObject(className, constructor);
            }
            catch (MoodAnalysisException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
            expected.Equals(obj);
        }
        //Method to test so mood analyser class return contructor not found(UC4-TC4.3)
        [TestCategory("REFLECTION")]
        [TestMethod]
        [DataRow("MoodAnalyserProblems.MoodAnalyser", "Linklist", "The Given Constructor Is Not Found")]
        [DataRow("MoodAnalyserProblems.MoodAnalyser", "Customer", "The Given Constructor Is Not Found")]
        public void ReturnDefaultConstructorNoConstructorFound(string className, string constructor, string expected)
        {
            object obj = null;
            try
            {
                obj = reflector.CreateMoodAnalyserObject(className, constructor);
            }
            catch (MoodAnalysisException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
        //Method to test moodanalyser class with parameter constructor to check if two objects are equal(UC5-TC5.1)
        [TestCategory("REFLECTION")]
        [TestMethod]
        [DataRow("I am in Happy mood")]
        [DataRow("I am in Sad mood")]
        [DataRow("I am in any mood")]
        public void GivenMessageReturnParameterizedConstructor(string message)
        {
            MoodAnalyser expected = new MoodAnalyser(message);
            object obj = null;
            try
            {
                obj = reflector.CreateMoodAnalyserParameterizedObject("MoodAnalyser", "MoodAnalyser", message);
            }
            catch (MoodAnalysisException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
            obj.Equals(expected);
        }
        //Method to test moodanalyser with diff class with parameter constructor to throw error(UC5-TC5.2)
        [TestCategory("REFLECTION")]
        [TestMethod]
        [DataRow("MoodAnalyser.Queues", "I am in Happy mood", "No Such Class")]
        [DataRow("MoodAnalyser.Linkedlist", "I am in Sad mood", "No Such Class")]
        [DataRow("MoodAnalyser.Stack", "I am in any mood", "No Such Class")]
        public void GivenMessageReturnParameterizedClassNotFound(string className, string message, string expextedError)
        {
            MoodAnalyser expected = new MoodAnalyser(message);
            object obj = null;
            try
            {
                obj = reflector.CreateMoodAnalyserParameterizedObject(className, "MoodAnalyser", message);
            }
            catch (MoodAnalysisException actual)
            {
                Assert.AreEqual(expextedError, actual.Message);
            }
        }
        //Method to test moodanalyser with diff constructor with parameter constructor to throw error(UC5-TC5.3)
        [TestCategory("REFLECTION")]
        [TestMethod]
        [DataRow("Customer", "I am in Happy mood", "No Such Constructor")]
        [DataRow("Linkedlist", "I am in Sad mood", "No Such Constructor")]
        [DataRow("Stack", "I am in any mood", "No Such Constructor")]
        public void GivenMessageReturnParameterizedConstructorNotFound(string constructor, string message, string expextedError)
        {
            MoodAnalyser expected = new MoodAnalyser(message);
            object obj = null;
            try
            {
                obj = reflector.CreateMoodAnalyserParameterizedObject("MoodAnalyser", constructor, message);
            }
            catch (MoodAnalysisException actual)
            {
                Assert.AreEqual(expextedError, actual.Message);
            }
        }
        //Method to invoke analyse mood method to return happy or sad(UC6-TC6.1)
        [TestCategory("REFLECTION")]
        [TestMethod]
        [DataRow("happy")]
        public void ReflectionReturnMethod(string expected)
        {
            string actual = reflector.InvokeAnalyserMethod("happy", "AnalyseMood");
            Assert.AreEqual(expected, actual);
        }
        //Method to invoke analyse mood method to return invalid method(UC6-TC6.2)
        [TestCategory("REFLECTION")]
        [TestMethod]
        [DataRow("No Such Method")]
        public void ReflectionReturnInvalidMethod(string expected)
        {
            try
            {
                string actual = reflector.InvokeAnalyserMethod("happy", "AnalyseMood");
            }
            catch (MoodAnalysisException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
        }
    }
}
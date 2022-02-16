using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
namespace MoodAnalyserProblems 
{
    /// <summary>
    /// Class to check a message, ability to analyse and respond happy or sad Mood
    /// </summary>
    public class MoodAnalyser 
    {
        //Declaring varibale
        public string message;
        //Constructor to initialize message 
=======
namespace MoodAnalyserProblems
{/// <summary>
 /// Class to check a message, ability to analyse and respond happy or sad Mood
 /// </summary>
    public class MoodAnalyser
    {
        //Declaring varibale(Refactor)
        public string message;
        //Constructor to initialize message(Refactor) 
>>>>>>> UC2_HandlingException
        public MoodAnalyser(string message) 
        {
            this.message = message;
        }
<<<<<<< HEAD
        //Method to analyse the mood from  the given message
        public string AnalyseMood() 
        {
            if (message.ToLower().Contains("sad"))
=======
        //Method to analyse the mood from  the given message(UC1)
        public string AnalyseMood() 
        {
            //Handling exception if user provide null value(UC2)
            try
>>>>>>> UC2_HandlingException
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch (NullReferenceException)
            {
                return "happy";
            }
        }
    }
}
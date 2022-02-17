using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MoodAnalyserProblems
{
    /// <summary>
    /// Class to check a message, ability to analyse and respond happy or sad Mood
    /// </summary>
    public class MoodAnalyser
    {
        //Declaring varibale(Refactor)
        public string message;
        //Default constructor(UC4)
        public MoodAnalyser()
        {
            Console.WriteLine("Default constructor");
        }
        //Constructor to initialize message(Refactor) 
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        //Method to analyse the mood from  the given message(UC1)
        public string AnalyseMood() 
        {
            //Handling exception if user provide null or empty value(UC2&UC3)
            try
            {
                //In case of null or empty mood throw custom exception MoodAnalysisException(UC3)
                if (this.message.Equals(null))
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionTypes.NULL_MOOD_EXCEPTION, "Message should not be null");
                else if (this.message.Equals(string.Empty))
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionTypes.EMPTY_MOOD_EXCEPTION, "Message should not be empty");
                else if (message.ToLower().Contains("sad"))
                    return "sad";
                else
                    return "happy";
            }
            catch (NullReferenceException)
            {
                return "happy";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MoodAnalyserProblems
{/// <summary>
 /// Class to check a message, ability to analyse and respond happy or sad Mood
 /// </summary>
    public class MoodAnalyser
    {
        //Declaring varibale(Refactor)
        public string message;
        //Constructor to initialize message(Refactor) 
        public MoodAnalyser(string message) 
        {
            this.message = message;
        }
        //Method to analyse the mood from  the given message(UC1)
        public string AnalyseMood() 
        {
            //Handling exception if user provide null value(UC2)
            try
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

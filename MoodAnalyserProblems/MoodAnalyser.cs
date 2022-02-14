using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MoodAnalyserProblems
{
    /// <summary>
    /// Creating Mood Analyser Class.
    /// </summary>
    public class MoodAnalyser
    {
        //Declaring Variables.
        public string message;
        //Parameterized Constructors.
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Creating Method for Happy Or Sad Mood.
        /// </summary>
        /// <returns></returns>
        public string AnalyseMood()
        {
            if (this.message.ToLower().Contains("sad"))
            {
                return "sad";
            }
            else
            {
                return "happy";
            }
        }
    }
}

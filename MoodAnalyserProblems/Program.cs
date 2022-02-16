using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MoodAnalyserProblems 
{
    /// <summary>
    /// Mood analyser program to analyse the mood
    /// </summary>
    public class Program
    {
        public static string msg = null;
        //Entry point to the program
        public static void Main(string[] args)
        {
            //Displaying the welcome message
            Console.WriteLine("==========Welcome To Mood Analyser Problems==========");
            //Calling the mood analyser object(UC1)  
            MoodAnalyser mood = new MoodAnalyser(msg);
            string resMood = mood.AnalyseMood();
            Console.WriteLine(resMood);
            Console.ReadLine();
        }
    }
}
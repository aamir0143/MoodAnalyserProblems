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
        //Entry point to the program
        public static void Main(string[] args)
        {
            //Displaying the welcome message
            Console.WriteLine("==========Welcome To Mood Analyser Problems==========");
            //Calling the mood analyser object(UC1)
            MoodAnalyser mood = new MoodAnalyser("Today Is A Happy Day For Me");
            string resMood = mood.AnalyseMood(); 
            Console.WriteLine("The mood is {0}", resMood);
            Console.ReadLine();
        }
    }
}
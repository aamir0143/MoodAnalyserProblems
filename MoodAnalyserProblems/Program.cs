// See https://aka.ms/new-console-template for more information
using System;
namespace MoodAnalyserProblems
{/// <summary>
 /// Mood analyser program to analyse the mood
 /// </summary>
    class Program
    {
        public static string msg = null;
        //Entry point to the program
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Mood Analyser Problems==========");
            //Calling the mood analyser object(UC1)
            MoodAnalyser mood = new MoodAnalyser(msg);
            string resMood = mood.AnalyseMood();
            Console.WriteLine(resMood);
            Console.ReadLine();
        }
    }
}

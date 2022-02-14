// See https://aka.ms/new-console-template for more information
using System;
namespace MoodAnalyserProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Mood Analyser Problems");
            //Calling the mood analyser object(UC1)
            MoodAnalyser mood = new MoodAnalyser("Today Is A Happy Day For Me");
            string resMood = mood.AnalyseMood();
            Console.WriteLine("The mood is {0}", resMood);
            Console.ReadLine();
        }
    }
}

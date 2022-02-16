<<<<<<< HEAD
﻿using System;
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
=======
﻿// See https://aka.ms/new-console-template for more information
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
>>>>>>> UC2_HandlingException
            Console.ReadLine();
        }
    }
}
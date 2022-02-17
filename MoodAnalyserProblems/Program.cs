using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            //Creating the object of mood analyser
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            moodAnalyser.Message = "I am happy today";
            Console.WriteLine();
            TestAnalysisModel(moodAnalyser);
            Console.ReadLine();
        }
        //Method to test the analysis class property
        public static void TestAnalysisModel(MoodAnalyser moodAnalyser) 
        {
            ValidationContext context = new ValidationContext(moodAnalyser, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(moodAnalyser, context, validationResults, true);
            if (!valid)
            {
                foreach (ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine("{0}", validationResult.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Satisfied all the validation");
            }
            Console.ReadLine();
        }
    }
}
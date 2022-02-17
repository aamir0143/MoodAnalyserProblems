using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MoodAnalyserProblems
{
    /// <summary>
    /// Simple Customer Class With Properties, Methods And Constructors
    /// </summary>
    public class Customer
    {
        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        //Parameterized Constructor
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        //Default Constructor
        public Customer()
        {
            this.Id = 20;
            this.Name = string.Empty;
        }
        //Method To Print Id
        public void PrintId()
        {
            this.Id = 22;
            Console.WriteLine("Id is : {0}", this.Id);
        }
        //Method To Print Name
        public void PrintName()
        {
            this.Name = "Aamir";
            Console.WriteLine("Name is : {0}", this.Name);
        }
    }
}

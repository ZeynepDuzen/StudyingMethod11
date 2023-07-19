using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingMethod11
{
    internal class Program
    {
        static void Child(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is : " + child3);
        }
        static void Main(string[] args)
        {
            // Child("Amy","Anna","Carol");
            Child(child3 : "Anna", child2 : "Amy", child1 : "Carol"); // order of the argument doesn't matter

            Console.Read();
        }
    }
}

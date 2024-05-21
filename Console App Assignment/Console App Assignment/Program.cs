using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is a do while loop
            int count = 0;
            do
            {
                Console.WriteLine("Inside the loop");
                count++; // add one to count each time 
            }
            while (count < 5); // continue until you reach 5

            // this is a while loop
            int counting = 0;
            while (counting < 3) // and the counting will be 3
            {
                Console.WriteLine("Counting numbers");
                counting++; // add one to counting each time
            }
            Console.ReadLine(); 
        }
    }
}

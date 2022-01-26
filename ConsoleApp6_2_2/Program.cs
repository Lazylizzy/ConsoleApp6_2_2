using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_2_2
{
    class Program
    {
        static void Main(string[] args)
        {           
            string startString = Console.ReadLine(); 
            startString = startString.Replace(" ", string.Empty); 
            startString = startString.ToLower(); 
            string newString = new string(startString.Reverse().ToArray()); 
            if (startString == newString)
            {
                Console.WriteLine("Данное предложение палиндром");
            }
            else
            {
                Console.WriteLine("Данное предложение не палиндром");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //call for the SayHi method

            SayHi();
            AddNumbers();
            
            Console.ReadLine();

        }

        static void SayHi()
        {
            Console.WriteLine(" your name ");
            string name = Console.ReadLine();

            Console.WriteLine("hi " + name);

           

        }
        static void AddNumbers() {

            Console.WriteLine("enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);
        
        }
    }
}

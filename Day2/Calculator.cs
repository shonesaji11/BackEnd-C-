using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            addNo();
            Console.ReadLine();
        }

        static void addNo()
        {
            int a;
            int b;
            Console.WriteLine("Enter first no : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first no : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is {0}", a + b);
            
        }
    }
}

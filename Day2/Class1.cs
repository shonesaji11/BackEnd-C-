using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayDemo
    {
        public void Trial()

        {
            int[] array1 = { 1, 2, 4, 6, 8, 9, 11, 14, 15 };
            var a = from i in array1 where i % 2 == 0 select i;
            Console.WriteLine("\n\nInside class1.cs ");
            foreach (var _a in a)
            {
                Console.WriteLine(_a);
            }
            Console.WriteLine("\n\n ");
            //Console.ReadLine();
        }

        public void addNumber()
        {
            int a;
            int b;
            Console.WriteLine("Enter some input : ");
        }
    }
}

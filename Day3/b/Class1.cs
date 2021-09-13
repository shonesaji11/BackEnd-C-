using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3b_PolymorphismDemo
{
    class RefAndOutDemo
    {
        
        public void random()
        {
            int result = 100;
            int result1;
            Add(out result, out result1 , result);
            Console.WriteLine("Using out keyword {0} , {1}",result , result1);
        }

        public void Add(out int a , out int  b , int result)
        {
            a = 10;
            a = result + a;

            b = 25;
        }

        public void RefDemo()
        {
            Console.WriteLine("\n\nDemonstrating ref keyword");
            string str1 = "Joseph";
            Console.WriteLine("Initial value of str1 , {0}" , str1);
          
            SetValue(ref str1);
            Console.WriteLine("Changing value of str1 by passing its reference , {0}",str1 , "\n\n");
        }

        public void SetValue(ref string str)
        {
            str = "Shone";
        }

    }
}

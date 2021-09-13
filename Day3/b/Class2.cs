using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3b_PolymorphismDemo
{
    class Calculator
    {
        public int num1, num2;

        public Calculator(int v1 , int v2)
        {
            num1 = v1;
            num2 = v2;
        }

        public static Calculator operator -(Calculator c1)
        {
            int temp;
            temp = c1.num1;
            c1.num1 = c1.num2;
            c1.num2 = temp;
            /*c1.num1 = -c1.num1;
            c1.num2 = -c1.num2;*/
            return c1;
        }

        public void print()
        {
            Console.WriteLine(num1.ToString()+ " ,  " + num2.ToString());
        }

    }

    class OperatorOverload
    {
        

    }
}

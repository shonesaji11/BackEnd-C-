using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DAY5_Delegate
{
    class Class3
    {
        public void class3fn()
        {
            int[] numbers = new int[5];
            numbers[0] = 10;

            System.Collections.ArrayList al = new System.Collections.ArrayList();
            Console.WriteLine("\n\n\nArray and ArrayList \nSize of ArrayList a1 is , {0}" , al.Capacity);

        }

        public void printInfo(List<dynamic> list)
        {
            foreach(dynamic no in list)
            {
                Console.Write(no);
                Console.Write("\t");
            }
        }

        public void sortDemo()
        {
            //We use List<int> for two reasons
            //1. we get the type safe property of simply int[]
            //2.we get the dynamic capability of ArrayList ; ArrayList has the drawback of not being type safe

            List<dynamic> list = new List<dynamic>() { 8, 6, 4, 5, 3, 2, 7, 9 };
            Console.WriteLine("\n\n\n Sorting Demo");
            Console.WriteLine("Before Sorting");
            printInfo(list);
            list.Sort();
            Console.WriteLine("\nAfter Sorting");
            printInfo(list);


            //String List

            List<dynamic> str_list = new List<dynamic>() { "Z", "B", "A", "D", "C" };
            Console.WriteLine("\n\nBefore Sorting");
            printInfo(str_list);
            str_list.Sort();
            Console.WriteLine("\nAfter Sorting");
            printInfo(str_list);

        }
    }
}

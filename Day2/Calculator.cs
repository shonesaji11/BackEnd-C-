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
            //addNo();
            dynamic val = "1000"; //"100.11" , "999999999999999999"
            /*int result;
            bool ifSuccess = int.TryParse(val, out result);
            Console.WriteLine(ifSuccess);*/

            //Boxing
            int i = 30;
            Object MyObj = i;
            Console.WriteLine(i);

            //UnBoxing
            Object MyObj1 = 40;
            int j = (int)MyObj1;
            Console.WriteLine(j);
            while (true)
            {
                string no;
                Console.Write("Enter Number :");
                no = Console.ReadLine();
                int result;
                
                try
                {   
                    if (no == "q")
                    {
                        break;
                    }
                    else
                    {
                        result = Convert.ToInt32(no);
                        Console.WriteLine("Result of Equation : {0}", QE(result));                       
                    }
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Integer Overflow !!");

                }
                catch
                {
                    Console.WriteLine("Enter Valid Integer");
                }
               
            }
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

        static int QE(int y)
        {
            return y*y + 2 * y + 1;
        }
    }
}

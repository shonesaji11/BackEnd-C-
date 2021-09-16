using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY5_Delegate
{
    //Normally for each method in the below class, we would need seperate delegates
    public delegate double del1(int x, float y, double z);
    public delegate void del2(int x, float y, double z);
    public delegate bool del3(string str);


    class Calculator
    {
        public double addNo1(int x , float y , double z)
        {
            return x + y + z;
        }

        public void addNo2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }

        public bool stringLength(string str)
        {
            if (str.Length > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


    class Class2
    {
        public void class2fn()
        {
            Calculator calcObj = new Calculator();
            /*del1 d1 = calcObj.addNo1;
            del2 d2 = calcObj.addNo2;
            del3 d3 = calcObj.stringLength;*/

            //Instead of declaring these 3 delegates we use func, action and predicate

            Func<int , float , double , double> d1 = calcObj.addNo1; //the last double is the return type
            Action<int, float, double> d2 = calcObj.addNo2; //Action is only for void functions
            Predicate<string> d3 = calcObj.stringLength; //Predicate only for bool

            Console.WriteLine("\n\n\nUsing standard delegates (Func<> , Action<> and Predicate<>) - {0}", d3("HelloWorld"));

        }
        
        

    }
}

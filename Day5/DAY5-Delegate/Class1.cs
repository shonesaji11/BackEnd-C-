using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY5_Delegate
{
    public delegate double RectangleDelegate(double a, double b);

    class Rectangle
    {
        public double getArea(double a , double b)
        {
            return a * b;
        }
        
    }

    class Class1
    {
        //we can use delegates to create a one line function without having to make a seperate class
        //same can be done using lambda
        public void function()
        {
            Rectangle recObj = new Rectangle();
            RectangleDelegate classicDelegate = recObj.getArea;

            Console.WriteLine("\n\nClassic way of using delegates , {0}", classicDelegate(10, 20));

            RectangleDelegate rd = delegate (double a, double b)
            {
                return a * b;
            };

            Console.WriteLine("Using one line delegate, {0}" , rd(10, 10));

            RectangleDelegate lambda = (double a, double b) =>
            {
                return a * b;
            };

            Console.WriteLine("Using lamda function, {0}", lambda(5, 5));
            

        }


    }
}

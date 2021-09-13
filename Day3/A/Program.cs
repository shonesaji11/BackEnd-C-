using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Shape //Super Class
    {
        //there is a default constructor even without explicitly mentioning 
        public double Width { get; set; }
        public double Height { get; set; }

        public Shape()
        {
            Console.WriteLine("super constructor is called");
        }
    }

    class Triangle : Shape
    {
        //extending from the shape class
        string kind;
        static long DateOfCreation;
        static Triangle()
        {
            //we can access only static variable
            //for initialization which only be required once whenver the class is invoked for the first time
            DateOfCreation = DateTime.Now.Ticks;
            Console.WriteLine("Called only once");

        }

        public Triangle(double v1, double v2): this(v1)//constructor
        {
            //Width  = v1; code duplication ; constructor with more parameters will call constructor with less no of parameters
            Height = v2;
        }

        public Triangle(double v1):base()
        {
            Width = v1; //if argument variable is Width(instead of v1) then mention as this.Width = Width
        }

        /*private Triangle(double area)
        {
            //cant be called from main
            //used to implement singleton design pattern
            //singleton - create one object from class
        }*/


    }

    class Program
    {
        static void Main(string[] args)
        {
            BasicsOfInheritance();


        }

        private static void BasicsOfInheritance()
        {
            Triangle t1 = new Triangle(10.1, 10.6); // reference is created and an object ; reference points to object
            Triangle t2 = t1; //t2 is reference which points to object that is pointed by reference t1
            Console.WriteLine(t1 == t2);
            new Triangle(10.1, 10.6);
            //new Triangle()  cannot create objects from static constructor
            Triangle triangleWithWidth = new Triangle(10.5);
            Console.WriteLine(triangleWithWidth.Width);
            Console.Read();
        }
    }
}

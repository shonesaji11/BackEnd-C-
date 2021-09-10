using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyClass
{
    public string myField = string.Empty;

    public MyClass()
    {
    }

    public void MyMethod(int parameter1, string parameter2)
    {
        Console.WriteLine("First Parameter {0}, second parameter {1}",
                                                    parameter1, parameter2);
    }

    public void paint(int parameter)
    {

        for (int i = parameter; i > 0; i--)
        {
            string result = new String('*', i);
            Console.WriteLine(result);
        }

    }


    public int MyAutoImplementedProperty { get; set; }

    private int myPropertyVar;

    public int MyProperty
    {
        get { return myPropertyVar; }
        set { myPropertyVar = value; }
    }
}


public class MyCar
{


    string carManufacturer { get; set; }
    string carModel { get; set; }
    int carMileage { get; set; }
    int noDoors { get; set; }
    int fuelCapacity { get; set; }
    bool spareTyre { get; set; }
    int noCylinders { get; set; }
    int horsePower { get; set; }
    int torque { get; set; }
    int tyreSize { get; set; }


}

public class User
{
    public string name { get; set; }

}


namespace ConsoleApp1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            byte b1 = 45; //455 wont work
            sbyte b2 = -45; //assigning b1 = b2 will not work
            Console.WriteLine("{b1} and {b2}");

            Object obj = new object();
            User user1 = new User();
            obj = user1;
            Console.WriteLine(typeof(User));
            Console.WriteLine(user1 is User);
            Console.ReadLine();


            



    }
}


}










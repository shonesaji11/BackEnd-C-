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


    public string carManufacturer { get; set; }
    public string carModel { get; set; }
    public int carMileage { get; set; }
    public int noDoors { get; set; }
    public int fuelCapacity { get; set; }
    public bool spareTyre { get; set; }
    public int noCylinders { get; set; }
    public int horsePower { get; set; }
    public int torque { get; set; }
    public int tyreSize { get; set; }

}



public class Program
{

    public static void Main(string[] args)
    {
        int num = 100;
        float rate = 10.2f;
        decimal amount = 100.50M;
        char code = 'C';
        bool isValid = true;
        string name = "Steve";

        Console.WriteLine(num);
        Console.WriteLine(rate);
        Console.WriteLine(amount);
        Console.WriteLine(code);
        Console.WriteLine(isValid);
        Console.WriteLine(name);

        MyClass ob = new MyClass();
        ob.MyMethod(10, "Ten");
        ob.MyProperty = 20;
        Console.WriteLine(ob.MyProperty);


        int i = 10, j = 20;
        if (i < j)
        {
            Console.WriteLine("i is less than j");
        }

        if (i > j)
        {
            Console.WriteLine("i is greater than j");
        }

        int i = 10, j = 20;
        Console.Write(i);
        if (isGreater(i, j))
        {
            Console.WriteLine("i is less than j");
        }

        else
        {
            Console.WriteLine("i is greater than j");
        }


        int x = 10;

        switch (x)
        {
            case 5:
                Console.WriteLine("Value of x is 5");
                break;
            case 10:
                Console.WriteLine("Value of x is 10");
                break;
            case 15:
                Console.WriteLine("Value of x is 15");
                break;
            default:
                Console.WriteLine("Unknown value");
                break;
        }



        switch (x)
        {
            case 1:
                Console.WriteLine("x = 1");
                break;
            case 2:
                Console.WriteLine("x = 2");
                break;
            case 4:
            case 5:
                Console.WriteLine("x = 4 or x = 5");
                break;
            default:
                Console.WriteLine("x > 5");
                break;
        }


        int x = 5;

        int j = 5;

        switch (j)
        {
            case 5:
                Console.WriteLine(5);
                switch (j - 1)
                {
                    case 4:
                        Console.WriteLine(4);
                        switch (j - 2)
                        {
                            case 3:
                                Console.WriteLine(3);
                                break;
                        }
                        break;
                }
                break;
            case 10:
                Console.WriteLine(10);
                break;
            case 15:
                Console.WriteLine(15);
                break;
            default:
                Console.WriteLine(100);
                break;
        }



        int x = 5;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Value of i: {0}", i);
        }



        int x = 5;

        for (double d = 1.01D; d < 1.10; d += 0.01D)
        {
            Console.WriteLine("Value of i: {0}", d);
        }


        int x = 5;

        for (int i = 0, j = 0; i + j < 5; i++, j++)
        {
            Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
        }



        for (int i = 7; i > 0; i--)
        {
            string result = new String('*', i);
            Console.WriteLine(result);
        }

        MyClass ob = new MyClass();
        ob.paint(10);

    }

    static bool isGreater(int i, int j)
    {
        if (i < j)
        {
            return false;
        }
        else
        {
            return true;
        }

    }
}








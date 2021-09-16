using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{

    //Delegate
    //defining\\


    public delegate void  AddNumberDelegate(int a , int b);
    public delegate string SayHelloDelegate(string str); //type order and no of parameters must be same ; var name can change

    class Calculator
    {
        public void AddNumber(int a , int b)
        {
            Console.WriteLine(a+b);
        }


        public static string SayHello(string name)
        {
            return "Hello " + name;
        }

    }

    class Program
    {
        static void Main2(string[] args)
        {
            Calculator cobj = new Calculator();
            cobj.AddNumber(10,20);

            string result = Calculator.SayHello("Shone"); // this is how we call a static method

            //Initialization
            AddNumberDelegate ad = new AddNumberDelegate(cobj.AddNumber); //MUST PASS method with same signature ; WE DONT TYPE cobj.AddNumber() since we are only passing reference
            //we can also call AddNumberDelegate ad = cobj.AddNumber;
            SayHelloDelegate sd  = Calculator.SayHello;


            //invoke
            ad.Invoke(50 , 60);
            string result1 = sd.Invoke("Shone");

            Console.ReadKey();


        }
    }
}

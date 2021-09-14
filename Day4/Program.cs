using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using patientModule;

namespace Day4
{

    class User
    {
        public string title { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailId { get; set; }
        
    }
    class Program
    {
        class IndexedClass
        {
            private String[] names = new string[10];
            readonly int a = 10;
            //const requires the variable to initialized at the place where it is defined

            public IndexedClass()
            {
                a = 10; //we can initialize a readonly variable outside its definition only inside the constructor
            }

            public string this[int index]
            {
                get
                {
                    return (index >= 0 && index <= 9) ? names[index] : "";
                }
                set
                {
                    if (index >= 0 && index <= 9)
                    {
                        names[index] = value;
                    }
                }
            }

            public int this[string name]
            {
                get
                {
                    int index = 0;
                    while(index < 10)
                    {
                        if(names[index] == name)
                        {
                            return index;
                        }
                        index++;
                    }
                    return -1;
                }
            }


        }

        static void Main(string[] args)
        {
            IndexedClass nameList = new IndexedClass();
            nameList[0] = "peanut";
            nameList[1] = "hazelnut";

            Console.WriteLine(nameList[0]);
            Console.WriteLine(nameList["peaut"]);

            Console.Read();
        }
    }
}

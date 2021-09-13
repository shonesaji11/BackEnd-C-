using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3b_PolymorphismDemo
{
    enum role
    {
        Developer=5 , Delivery_Manager
    }

    class User
    {
        const int age = 10;
        public User(string name)
        {
            const int age = 100;
            this.name = name;
            Console.WriteLine("User Constructor , {0}" , age);
            Console.WriteLine("User Constructor , {0}", User.age);
        }

        public string name { get; } //immutable ; we dont want to change the name after the object is created. ; get method to make it read only
        public role role { get; set; } //enum can be used when we have a fixed set of values 
        public void Enter()
        {
            Console.WriteLine("User entered");
        }
    }

    class Employee: User
    {
        public Employee(string name): base(name)
        {
            
        }
        public virtual void Enter() //OVERRIDING
        {
            //using the keyword new overrides the Enter() method of the User class
            Console.WriteLine("User entered - inside employee :  {0}" , this.name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Shone");
            e1.Enter();
            e1.role = role.Developer;
            Console.WriteLine(e1.role);
            Console.WriteLine((int)e1.role);
            string strRole = role.Delivery_Manager.ToString(); // only role.Delivery_Manager wont work because it is of type enum

            /*Employee e2 = new Employee("Joseph");
            e2.Enter();*/

            /*User u1 = new User();
            u1.Enter();

            User e2 = new Employee();
            e2.Enter();*/

            RefAndOutDemo obj = new RefAndOutDemo();
            obj.random();
            obj.RefDemo();

            Calculator calc = new Calculator(15, 25); //overloading demo ; 
            calc = -calc; //we have used the '-' symbol to swap elements as opposed to making it negative
            calc.print();

            Console.Read();
        }
    }
}

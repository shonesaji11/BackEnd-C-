using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Practical use case of delegates
//we want to promote an employee - promotion can be based on salary , exp 
//normally we will hardcode the logic inside the class
// here we will set the logic in an outside function and pass that as arugument to a method in the class

namespace Day5
{

    public delegate bool promoted(Employee empl)

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void Promoted(List<Employee> empList , promoted prom)
        {
            foreach(Employee employee in empList)
            {
                if (prom(employee))
                {
                    Console.WriteLine(employee.Name);
                }
            }
        }

    }


    class demo
    {
        static void main()
        {
            List<Employee> emp = new Employee();

            emp.Add(new Employee() { Id = 101, Name = "Mark", Salary = 5000, Experience = 3 });
            emp.Add(new Employee() { Id = 102, Name = "Smith", Salary = 3000, Experience = 5 });
            emp.Add(new Employee() { Id = 103, Name = "Watson", Salary = 6000, Experience = 8 });
            emp.Add(new Employee() { Id = 104, Name = "Paul", Salary = 8000, Experience = 6 });


            isPromoted prom = new promoted(isPromoted);

            Employee.Promoted(emp, prom);

        }


        public static bool isPromoted(Employee empl)
        {
            if (empl.Salary  >= 5000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DAY5_Delegate
{

    //Practical use case of delegates
    //we want to promote an employee - promotion can be based on salary , exp 
    //normally we will hardcode the logic inside the class
    // here we will set the logic in an outside function and pass that as arugument to a method in the class

    public delegate bool promotedDelegate(Employee empl);
    
    public class Employee: IComparable<Employee>
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            public int Experience { get; set; }

            public static void Promoted(List<Employee> empList, promotedDelegate prom)
            {
                foreach (Employee employee in empList)
                {
                    if (prom(employee))
                    {
                        Console.WriteLine(employee.Name);
                    }
                }
            }

            public static void DisplayEmployeeInfo(List<Employee> empList)
                {
                    foreach (Employee employee in empList)
                    {
                            Console.WriteLine("Employee Name : {0}, Employee Salary : {1}" , employee.Name , employee.Salary);
                    }
                }

            public int CompareTo(Employee other)
            {
            if (this.Id > other.Id)
            {
                return 1;
            } else if (this.Id < other.Id)
            {
                return -1;
            }
            else
            {
                return 0;
            }
            }



        /*public void PromotedS(List<Employee> empList , promotedDelegate prom)
        {

        }*/
    }


    public class SortEmployeeById : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }


    class Program
        {
            static void Main()
            {
                Employee obj = new Employee();
                List<Employee> emp = new List<Employee>();

                emp.Add(new Employee() { Id = 106, Name = "Mark", Salary = 5000, Experience = 8 });
                emp.Add(new Employee() { Id = 102, Name = "Smith", Salary = 3000, Experience = 6 });
                emp.Add(new Employee() { Id = 103, Name = "Watson", Salary = 6000, Experience = 3 });
                emp.Add(new Employee() { Id = 104, Name = "Paul", Salary = 8000, Experience = 5 });


                promotedDelegate promSal = new promotedDelegate(isPromotedSal);
                promotedDelegate promExp = new promotedDelegate(isPromotedExp);

                Console.WriteLine("Displaying employee information");
            //sorting a custom data type - here employee

            //first way of sorting
            //emp.Sort();


            //second way of sorting
            SortEmployeeById sortEmployeebyIdobj = new SortEmployeeById();
            emp.Sort(sortEmployeebyIdobj);
            Employee.DisplayEmployeeInfo(emp);

            Console.WriteLine("\n\n\n");

            //third way of sorting
            //Comparison<Employee> comparison = ComparisonById;
            //emp.Sort(comparison);

            //another way
            /*Comparison<Employee> comparison = delegate (Employee e1, Employee e2)
            {
                return e1.Id.CompareTo(e2.Id);
            };*/

            Comparison<Employee> comparison = (e1, e2) =>
            {
                return e1.Id.CompareTo(e2.Id);
            };
            emp.Sort(comparison);
            Employee.DisplayEmployeeInfo(emp);






                
                Console.WriteLine("\n\n\nPromotion Based on Salary - ");
                Employee.Promoted(emp, promSal);
                Console.WriteLine("Promotion Based on Experience - ");
                Employee.Promoted(emp, promExp);
            //obj.PromotedS(emp, promExp);


            //Demonstrating various ways to use delegate
            Class1 classobj = new Class1();
            classobj.function();


            //Demonstrating multi-delegates
            //standard delegates - func(when you have a return type) ; action(when you do not have a return type) ; predicate(when you have bool return type)
            Class2 classobj2 = new Class2();
            classobj2.class2fn();


            //Defining array and arrayList
            Class3 classobj3 = new Class3();
            classobj3.class3fn();

            //Sorting Demo
            classobj3.sortDemo();

            Console.ReadKey();

            }


            public static bool isPromotedSal(Employee empl)
            {
                if (empl.Salary > 5000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public static bool isPromotedExp(Employee empl)
            {
                if (empl.Experience > 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static int ComparisonById(Employee e1, Employee e2)
        {
            return e1.Id.CompareTo(e2.Id);
        }
    }


    
}

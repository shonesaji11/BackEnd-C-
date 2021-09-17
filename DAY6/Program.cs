using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY6
{
    public class StudentClass : IComparable<StudentClass>
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public byte studentAge { get; set; }
        
        public int CompareTo(StudentClass std)
        {
            return this.studentId.CompareTo(std.studentId);
        }

        public void DisplayStudentDetails(List<StudentClass> stdList)
        {
            foreach(StudentClass std in stdList)
            {
                Console.WriteLine("Student Id : {0}, Student Name : {1}, Student Age : {2}" , std.studentId , std.studentName , std.studentAge);
            }
        }

    }


    public class SortStudentByAge : IComparer<StudentClass>
    {
        public int Compare(StudentClass std1 , StudentClass std2)
        {
            return std1.studentName.CompareTo(std2.studentName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Program obj = new Program();

            //REVERSING A STRING
            string str = "Hello World";
            obj.ReverseString(str);


            //Finding largest number in array
            List<int> numbers = new List<int>() { 2, 3, 4, 2, 56 ,12, 34 , 12,1, 33 ,0 };
            obj.FindLargestNo(numbers);


            //Swapping two numbers
            obj.SwapNo(10, 20);


            //Creating a collection of student ; sorting it by name and id
            obj.student();


            Console.Read();

        }

        public void student()
        {
            StudentClass studentObj = new StudentClass();
            List<StudentClass> studentList = new List<StudentClass>();

            studentList.Add(new StudentClass() {studentId = 101 , studentAge = 17 , studentName="Mark" });
            studentList.Add(new StudentClass() { studentId = 102, studentAge = 16, studentName = "John" });
            studentList.Add(new StudentClass() { studentId = 103, studentAge = 19, studentName = "Paul" });
            studentList.Add(new StudentClass() { studentId = 104, studentAge = 15, studentName = "James" });
            studentList.Add(new StudentClass() { studentId = 100, studentAge = 20, studentName = "David" });

            //Sort studentList based on Id
            studentList.Sort();
            Console.WriteLine("\n\n\nSorting based on Id ");
            studentObj.DisplayStudentDetails(studentList);

            //Sort studentList based on Age
            SortStudentByAge agesortobj = new SortStudentByAge();
            studentList.Sort(agesortobj);
            Console.WriteLine("\n\n\nSorting based on Name ");
            studentObj.DisplayStudentDetails(studentList);
        }

        public  void ReverseString(string str)
        {
            string result = "";

            foreach (char character in str)
            {
                result = character + result;
            }

            Console.WriteLine("Input String : {0}", str);
            Console.WriteLine("Reversed String : {0}", result);
        }


        public void FindLargestNo(List<int> numbers)
        {
            int maxNo = 0;
            foreach(int number in numbers)
            {
                if(number > maxNo)
                {
                    maxNo = number;
                }
            }

            Console.WriteLine("\n\n\nThe largest no in given array is {0}", maxNo);
        }


        public void SwapNo(int a , int b)
        {
            Console.WriteLine("\n\n\nBefore swapping a and b : {0} , {1}" , a, b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping a and b : {0} , {1}", a, b);
        }

    }
}

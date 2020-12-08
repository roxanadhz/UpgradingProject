using System;

namespace ProjectWithNull
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Roxana", "Dehzad");
            Student student1 = new Student("Roxana", "None", "Dehzad");
            Console.WriteLine($"Welcome, {student.Name} {student.LastName}");
            Console.WriteLine($"The Length of {student.Middle}={GetMiddleLength(student)}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Welcome, {student1.Name} {student1.Middle} {student1.LastName}");
            Console.WriteLine($"The Length of {student1.Middle}={GetMiddleLength(student1)}");

        }
        static int GetMiddleLength(Student student)
        {
            var middleName = student.Middle;
            return middleName?.Length ?? 0;
        }
    }
}


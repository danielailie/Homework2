
using System;

namespace Week3Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            AddAStudentFromTheConsole();
            var student2=new Student("Gabriela","Ghita",18);
            Console.WriteLine("The number of persons added is: {0} ",Person.Contor);
        }

        private static void AddAStudentFromTheConsole()
        {
            Console.WriteLine("Give the firstname off the student: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Give the surname off the student: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Give the age off the student: ");
            int age = Int16.Parse(Console.ReadLine());
            var student = new Student(firstName, surname, age);
        }
    }
}

using System;

namespace Week3Ex3
{
    class Student:Person
    {
        public int Age { get; set; }
        public Student(string firstname, string surname, int age) : base(firstname, surname)
        {
            Age = age;
            Console.WriteLine("The constructor from the student class is called");
        }


    }
}

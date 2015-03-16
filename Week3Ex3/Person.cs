using System;

namespace Week3Ex3
{
    class Person
    {
        public string Firstname { get; private set; }
        public string Surname { get; private set; }

        public static int Contor;

        static Person()
        {
            Contor = 0;
            Console.WriteLine("The Static Constructos is called first");
        }
        public Person(string firstname, string surname)
        {
            Firstname = firstname;
            Surname = surname;
            Contor++;
            Console.WriteLine("The constructor from the Person class is called! ");

        }


    }
}

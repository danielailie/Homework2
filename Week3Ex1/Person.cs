using System;
using System.Linq;

namespace Week3Ex1
{
    class Person
    {
        public string Firstname { get; private set; }
        public string Surname { get; private set; }

        public Person(string firstname,string surname)
        {
            Firstname = firstname;
            Surname = surname;
        }

        public Person(string name)
        {
            getTheSurnameAndTheFirstname(name);
        }

        private void getTheSurnameAndTheFirstname(string name)
        {
            string[] names= name.Split(' ');
            Surname = names[0];
            for (int i = 1; i < names.Count(); i++)
                Firstname += names[i]+ ' ';
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", Surname, Firstname);
        }
    }
}

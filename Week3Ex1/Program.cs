using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1=new Person("Delia","Ionescu");
            var person2 = new Person("Ghita Ioana Mihaela Corina");
            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
        }
    }
}

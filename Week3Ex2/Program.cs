

using System;

namespace Week3Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tank1=new Tank(true);
            tank1.Add();
            tank1.Dispose();
            Console.WriteLine("The tank1 is filled? {0}",  tank1.isFull );

            var tank2 = new Tank(false);
            tank2.Dispose();
            Console.WriteLine("The tank2 is filled? {0}", tank2.isFull);

            var tank3 = new Tank(false);
            tank3.Add();
            tank3.EmptyTheTank();
            tank3.Dispose();
            Console.WriteLine("The tank3 is filled? {0}", tank3.isFull);
        }
    }
}

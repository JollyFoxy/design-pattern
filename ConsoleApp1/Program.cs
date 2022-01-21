using System;
using System.Collections.Generic;
using System.Text;
using UtkaL;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck[] Uti = new Duck[]
            {
                new MallardDuck(),
                new RedheadDuck(),
                new RubberDuck(),
                new DecoyDuck(),
            };
            foreach (Duck utya in Uti)
            {
                Console.WriteLine(utya.Swim());
                Console.WriteLine(utya.Display());
                if(utya is IFlyable)
                {
                    Console.WriteLine((utya as IFlyable).fly());
                }
                if (utya is IQuackble)
                {
                    Console.WriteLine((utya as IQuackble).quack());
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

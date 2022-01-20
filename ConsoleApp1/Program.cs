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
            Duck[] kryak = new Duck[]
            {
                new MallardDuck(),
                new RedheadDuck()
            };
            foreach (Duck kyra in kryak)
            {
                Console.WriteLine(kyra.Swim());
                Console.WriteLine(kyra.Quack());
                Console.WriteLine(kyra.Display());
            }
            Console.ReadKey();
        }
    }
}

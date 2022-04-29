using System;

namespace AbstractFactory
{
    public class Program
    {
        public static void Main()
        {
            var elf = new Hero(new Elf());
            elf.Move();
            elf.Hit();
            Console.WriteLine();
            var ork = new Hero(new Ork());
            ork.Move();
            ork.Hit();
        }
    }
}
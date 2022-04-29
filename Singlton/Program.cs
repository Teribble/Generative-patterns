using System;

namespace Singlton
{
    public class Program
    {
        public static void Main()
        {
            Computer comp = new Computer();
            comp.RunPC("Windows 10");
            Console.WriteLine(comp.OS.Name);

            comp.OS = OS.GetOS("Linux");
            Console.WriteLine(comp.OS.Name);
        }
    }
}
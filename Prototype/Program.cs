using System;

namespace Prototype
{
    public class Program
    {
        public static void Main()
        {
            IFigure rec = new Rectangle(4, 5);
            var recClone = rec.Clone();

            rec.GetInfo();
            recClone.GetInfo();
            Console.WriteLine("Rec == RecClone" + ": " + (rec == recClone).ToString());

            IFigure cir = new Circle(5);
            var cirClone = cir.Clone();

            cir.GetInfo();
            cirClone.GetInfo();
            Console.WriteLine("Cir == CirClone" + ": " + (cir == cirClone).ToString());
        }
    }
}
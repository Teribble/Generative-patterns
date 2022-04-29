using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class WoodBuilder : CompanyBuilder
    {
        public WoodBuilder(string name) : base (name)
        {
            
        }

        public override House Create()
        {
            Console.Write(base.Name + ": ");
            return new WoodHouse();
        }
    }
}

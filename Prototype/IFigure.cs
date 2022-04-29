using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public interface IFigure
    {
        public IFigure Clone();

        public void GetInfo();
    }
}

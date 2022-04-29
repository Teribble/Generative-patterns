using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton
{
    public class Computer
    {
        public OS? OS { get; set; }

        public void RunPC(string name)
        {
            OS = OS.GetOS(name);
        }
    }
}

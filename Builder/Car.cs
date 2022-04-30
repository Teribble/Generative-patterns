using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Car
    {
        public Engine Engine { get; set; }

        public Frame Frame { get; set; }

        public Wheel Wheel { get; set; }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            if (Engine != null)
                st.Append(Engine.Model + "\n");
            if (Frame != null)
                st.Append(Frame.Country + "\n");
            if (Wheel != null)
                st.Append(Wheel.Company + "\n");

            return st.ToString();
        }
    }
}

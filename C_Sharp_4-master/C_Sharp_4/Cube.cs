using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_4
{
    class Cube
    {
        double r;

        public double GetSquare()
        {
            return Math.Pow(r, 3);
        }

        new public string ToString()
        {
            return "\nСторона:" + this.R + " " +
                 "\nПлощадь:" + this.GetSquare() + " " ;
        }

        public double R { get => r; set => r = value >= 0 ? value : 0; }
    }
}

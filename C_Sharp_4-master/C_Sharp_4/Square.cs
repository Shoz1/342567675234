using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_4
{
    class Square
    {
        
        double r;
        

        public double GetD()
        {
            return Math.Sqrt(2)*r;
        }

        public double GetSquare()
        {
            return Math.Pow(r,2);
        }

        new public string ToString()
        {
            return "\nРадиус:" + this.R + " " +
                 "\nПериметр:" + this.GetSquare() + " " +
                 "\nПлощадь:" + this.GetSquare() + " " +
                 "\nДиагональ:" + this.GetD();
        }

        public double R { get => r; set => r = value >= 0 ? value : 0; }
    }
}

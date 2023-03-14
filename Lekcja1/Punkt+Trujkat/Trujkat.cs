using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punkt
{
    internal class Trujkat
    {
        int a;
        double h;
        public int bok
        {
            set 
            { 
                a = value;
                h = a*System.Math.Sqrt(3)/2;
            }
        }
        public double pole()
        {
            return a * h / 2;
        }
    }
}

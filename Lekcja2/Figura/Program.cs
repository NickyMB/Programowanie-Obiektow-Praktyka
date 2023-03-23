using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    class Figura
    {
        private double a, b, c, r;

        public Figura(double x) 
        { 
            r = x;
        }
        public Figura(double x, double y) 
        { 
            a = x;
            b = y;
        }
        public Figura(double x, double y, double z)
        {
            a = x;
            b = y;
            c = z;
        }
        public Figura(Figura l)
        {
            a = l.a;
            b = l.b;
            c = l.c;
            r = l.r;
        }
        public double parametr1
        {
            set 
            { 
                if(r>0)
                    r = value;
                else
                    a = value;
            }
        }
        public double ObliczObwod()
        {
            if(r>0) 
            { 
                return  r*3.14*2;
            }
            else if (c>0)
            {
                return a + b + c;
            }
            else
               return (2*a)+(2*b);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Figura p1 = new Figura(1);
            Figura p2 = new Figura(4,5);
            Figura p3 = new Figura(2,3,5);
            Figura p4 = new Figura(p3);
            Figura p5 = p3;

            p3.parametr1 = 1;

            Console.WriteLine(p1.ObliczObwod());
            Console.WriteLine(p2.ObliczObwod());
            Console.WriteLine(p3.ObliczObwod());
            Console.WriteLine(p4.ObliczObwod());
            Console.WriteLine(p5.ObliczObwod());
            Console.ReadKey();
        }
    }
}

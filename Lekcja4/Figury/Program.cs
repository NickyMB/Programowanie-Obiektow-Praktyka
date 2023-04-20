using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    interface IFigura
    {
        double obwod { get; }
        double Pole();
    }
    class Kwadrat : IFigura
    {
        protected double a;
        public Kwadrat(double bok)
        {
            a = bok;
        }
        public double obwod
        {
            get { return 4 * a; }
        }
        public double Pole() 
        {
            return a * a;
        }
        
    }
    class Trujkat : IFigura
    {
        protected double a;
        protected double b;
        protected double c;
        protected double p;
        public Trujkat(double bok_a, double bok_b, double bok_c)
        {
            a = bok_a;
            b = bok_b;
            c = bok_c;
        }
        public double obwod
        {
            get { return a+b+c; }
        }
        public double Pole()
        {
            p = (a+b+c)/2;
            return Math.Sqrt(p*(p-a) * (p - b) * (p - c));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kwadrat kw = new Kwadrat(15);
            Trujkat tr = new Trujkat(4,5,6);
            Console.WriteLine($"Pole kwadratu wynosi {kw.Pole()} a obwód {kw.obwod}");
            Console.WriteLine($"Pole trójkąta wynosi {tr.Pole()} a obwód {tr.obwod}");
            
            Console.ReadLine();
        }
    }
}

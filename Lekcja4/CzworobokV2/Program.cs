using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CzworobokV2
{
    public abstract class Czworobok
    {
        protected int x;
        protected int y;
        protected double z;
        public Czworobok(int bok_a, int bok_b)
        {
            x = bok_a;
            y = bok_b;
        }
        public abstract double Pole();
    }
    
    public class Kwadrat : Czworobok
    {
        public Kwadrat(int bok_a)
            : base(bok_a, bok_a)
        {
        }
        public override double Pole()
        {
            return x * y;
        }
    }
    public class Trapez : Czworobok
    {
        public Trapez(int bok_a, int bok_b, double bok_c):base(bok_a,bok_b)
        {
            z = bok_c;
        }
        public override double Pole()
        {
            return ((x + y)*z)/2;
        }
    }
    public class Prostokat : Czworobok
    {
        public Prostokat(int bok_a, int bok_b): base(bok_a, bok_b)
        {
        }
        public override double Pole()
        {
            return x * y;

        }
    }
    class pokazik
    {
        public static void Main()
        {
            Czworobok kw = new Kwadrat(5);
            Czworobok pr = new Prostokat(5, 4);
            Czworobok tr = new Trapez(7,8,5);
            Czworobok[] tab = { kw, pr, tr };
            for (int i = 0; i < tab.Length; i++)
                Console.WriteLine(tab[i].Pole());
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scieszka
{
    public struct Punkt
    {
        public double x, y;
        public Punkt(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public static double Odleglosc(Punkt pkt1,Punkt pkt2)
        {
            return  Math.Round(Math.Sqrt(Math.Pow(pkt1.x - pkt2.x,2) + Math.Pow(pkt1.y - pkt2.y, 2)),2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            List<Punkt> punkciki = new List<Punkt>();
            int n = 1;
            double odl = 0;
            int x, y;
            do
            {
                Console.Write($"Podaj współrzędną x punktu ({n}): ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Podaj współrzędną y punktu ({n}): ");
                y = Convert.ToInt32(Console.ReadLine());
                punkciki.Add(new Punkt(x, y));
                if(n>1)
                {
                    odl += Punkt.Odleglosc(punkciki[punkciki.Count - 2], punkciki[punkciki.Count-1]);
                    Console.WriteLine($"Suma odległości między kolejnymi puktami: {odl}");
                }
                Console.WriteLine();
                n++;
            } while (n <= 5);
            odl = Punkt.Odleglosc(punkciki[0], punkciki[punkciki.Count - 1]);
            Console.WriteLine($"Odległość między pierszym,a ostatnim punktem: {odl}");

            Console.ReadKey();
        }
    }
}

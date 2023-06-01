using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludolfina
{
    interface ILeibniz
    {
        double Ludolfina(int n);
    }
    interface IEuler
    {
        double Ludolfina(int n);
    }
    class Obliczenia : ILeibniz, IEuler
    {

        double ILeibniz.Ludolfina(int n)
        {
            double lud = 0;
            for (int i = 0; i < n; i++)
                lud += Math.Pow(-1, i) / (2 * i + 1);
            return lud * 4;
        }
        double IEuler.Ludolfina(int n)
        {
            double lud = 0;
            for (int i = 1; i <= n; i++)
                lud += 1 / Math.Pow(i, 2);
            return Math.Sqrt(lud * 6);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Obliczenia ob1 = new Obliczenia();
            Console.WriteLine(Math.PI - ((ILeibniz)(ob1)).Ludolfina(20));
            Console.WriteLine(Math.PI - ((IEuler)(ob1)).Ludolfina(20));
            Console.ReadKey();
        }
    }
}

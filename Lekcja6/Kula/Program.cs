using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kula
{
    internal class Kula
    {
        private double promien;
        public Kula(double r) 
        { 
            promien = r;
        }
        public double Objetosc()
        {
            return Math.Round(4d/3 * Math.PI * Math.Pow(promien, 3),2);
        }
        public double PromienKuli
        { 
            get { return Math.Round(promien,2); }
        }
        public static Kula operator +(Kula k1, Kula k2) 
        {
            Kula k = new Kula(0);
            k.promien = Math.Pow((k1.Objetosc() + k2.Objetosc())/(4d/3*Math.PI),1f/3);
            return k;
        }
        public static Kula operator -(Kula k1, Kula k2)
        {
            Kula k = new Kula(0);
            if (k1.promien > k2.promien)
                k.promien = Math.Pow((k1.Objetosc() - k2.Objetosc()) / (4d / 3 * Math.PI), 1f / 3);
            else
                k.promien = 0;
            return k;

        }
    }
    internal class Program
    {
        private static List<Kula> Kule = new List<Kula>();
        static void Main(string[] args)
        {
            Kula Kulka1 = new Kula(3);
            Kula Kulka2 = new Kula(2.5);
            Kula Kulka3 = new Kula(1.8);
            Kule.Add(Kulka1);
            Kule.Add(Kulka2);
            Kule.Add(Kulka3);
            int i = 1;
            foreach (var n in Kule) 
            {
                Console.WriteLine($"Kulka {i} - Objętość: {n.Objetosc()} promień: {n.PromienKuli}");
                i++;
            }
            Kula KulaSuma = Kulka1-Kulka2+Kulka3;
            
            Console.WriteLine($"Kula wynikowa - Objętość: {KulaSuma.Objetosc()} Promień: {KulaSuma.PromienKuli}");
            Console.ReadKey();
        }
    }
}

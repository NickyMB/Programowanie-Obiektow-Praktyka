using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przestrzen
{
    internal class Program
    {
        private static List<Prosta> Punkty = new List<Prosta>();
        static void Main(string[] args)
        {
            Prosta Punkt1 = new Prosta(5);
            Prosta Punkt2 = new Prosta(-3);
            Prosta Punkt3 = new Plaszczyzna(2,5);
            Prosta Punkt4 = new Plaszczyzna(4,-3);
            Prosta Punkt5 = new Przestrzen(1,3,5);
            Prosta Punkt6 = new Przestrzen(-4,5,1);
            Punkty.Add(Punkt1);
            Punkty.Add(Punkt2);
            Punkty.Add(Punkt3);
            Punkty.Add(Punkt4);
            Punkty.Add(Punkt5);
            Punkty.Add(Punkt6);
            Prosta[] tabliczka = new Prosta[] {Punkt1, Punkt2, Punkt3, Punkt4, Punkt5, Punkt6};
            for(int i = 0; i < tabliczka.Length; i++) 
            {
                tabliczka[i].Odl_zero();
            }
                Console.ReadKey();
        }
    }
}

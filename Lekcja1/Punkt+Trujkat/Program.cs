using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punkt
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            void zadanie1()
            {
                Punkt p1 = new Punkt(3,4);
                Punkt p2 = new Punkt(0,0);
                p1.Wyswielt();
                p1.Przesun(1, 2);
                p1.Wyswielt();
                p1.Cofnij_Przesun();
                Console.WriteLine(Punkt.Odleglosc2punktuw(p1,p2));
            }

            void zadanie2()
            {
                Trujkat tr;
                tr = new Trujkat();
                tr.bok = 3;
                Console.WriteLine(tr.pole());
                tr.bok = 5;
                Console.WriteLine(tr.pole());
            }

            string z_adania;
            int a = 0;

            do
            {
                Console.WriteLine($"{Environment.NewLine}Podaj nr. zadania od 1-2");
                Console.WriteLine($"{Environment.NewLine}1-Punkt");
                Console.WriteLine($"{Environment.NewLine}2-Trójkąt");
                Console.WriteLine($"");
                z_adania = Console.ReadLine();
                switch (z_adania)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine($"Zadanie {z_adania}:");
                        zadanie1();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"Zadanie {z_adania}:");
                        zadanie2();
                        break;
                    default:
                        Console.Clear();
                        Console.Write("Proszę o wybranie numeru zadania z zakresu 1 - 2");
                        Console.WriteLine();
                        break;
                }
                a++;
            } while (a <= 12);
        }
    }
}

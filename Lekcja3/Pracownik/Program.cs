using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownik
{
    internal class Program
    {
        private static List<Pracownik> Zaloga = new List<Pracownik>();
        static void Main(string[] args)
        {
            double Pra = 0, Kie = 0, Dyr = 0, IlP = 0, IlD=0,IlS=0 ;
            Pracownik p1 = new Pracownik("Present","Andy",5000);
            Pracownik p2 = new Pracownik("Absent","Kate",4500);
            Pracownik p3 = new Pracownik("Who","Knows",4000);
            Pracownik k1 = new Kierownik("Janik","Adam",8000);
            Pracownik d1 = new Dyrektor("Kasztan","Arnold",10000);
            Zaloga.Add(p1);
            Zaloga.Add(p2);
            Zaloga.Add(p3);
            Zaloga.Add(k1);
            Zaloga.Add(d1);
            foreach (Pracownik p in Zaloga)
            {
                Console.WriteLine($"{p.GetType().Name}:");
                p.Wypisz();
                switch(p.GetType().Name.ToString())
                {
                    case "Pracownik":
                        Pra += p.Premia();
                        IlP++;
                        break;
                    case "Kierownik":
                        Kie += p.Premia();
                        IlS++;
                        break;
                    case "Dyrektor":
                        Dyr += p.Premia();
                        IlD++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Średnia premia pracownika {Pra/ IlP} Średnia premia szefostwa {(Kie+Dyr)/(IlD+IlS)}");
            Console.ReadKey();
        }

    }
}

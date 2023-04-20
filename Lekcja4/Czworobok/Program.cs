using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfizm
{

    public abstract class Czworobok
    {
        protected int x;
        protected int y;
        public Czworobok(int bok_a, int bok_b)
        {
            x = bok_a;
            y = bok_b;
        }
        /*
        //rozw .1
        public virtual double Pole()
        {
            return 123;
        }
        */
        public abstract double Pole();

    }

    public class Kwadrat : Czworobok
    {
        public Kwadrat(int bok_a)
            : base(bok_a, bok_a)
        {
        }
        /*
        //rozw .1
        public override double Pole()
        {
            return x * y;

        }*/

        /*
        //rozw .2
        public double Pole()
        {
            return x * y;
        }*/

        //rozw .3
        public override double Pole()
        {
            return x * y;

        }
    }

    public class Prostokat : Czworobok
    {
        public Prostokat(int bok_a, int bok_b)
            : base(bok_a, bok_b)
        {
        }
        /*
        //rozw .1
        public override double Pole()
        {
            return x * y;

        }*/

        /*
        //rozw .2
        public double Pole()
        {
            return x * y;
        }*/

        //rozw .3
        public override double Pole()
        {
            return x * y;

        }
    }



    class pokazik
    {

        public static void Main()
        {
            // Rozwiaz problem z metoda Pole() trzema sposobami:

            // 1.Tworzac metode w klasie bazowej i stosujac polimorfizm

            // 2.Stosujac wlasciwosc GetType().Name i rzutowanie

            // 3.Stosujac metode abstrakcyjna w klasie bazowej

            Czworobok kw = new Kwadrat(5);
            Czworobok pr = new Prostokat(5, 4);

            Czworobok[] tab = { kw, pr };
            /*
                //rozw .1
                for (int i = 0; i < tab.Length; i++)
                {
                    Console.WriteLine(tab[i].Pole());
                }
            */
            /*
            //rozw .2
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i].GetType().Name == "Kwadrat")
                    Console.WriteLine(((Kwadrat)(tab[i])).Pole());

                else if (tab[i].GetType().Name == "Prostokat")
                    Console.WriteLine(((Prostokat)(tab[i])).Pole());
            }*/

            //rozw .3
            for (int i = 0; i < tab.Length; i++)
                Console.WriteLine(tab[i].Pole());
            Console.ReadLine();
        }
    }
}

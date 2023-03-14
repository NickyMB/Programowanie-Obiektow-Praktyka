using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class Prostokat
    {
        private int dlugosc, szerokosc;
        public Prostokat(int dlu, int szer)
        {
            dlugosc = dlu;
            szerokosc = szer;
        }
        private int obwod()
        {
            return 2 * dlugosc + 2 * szerokosc;
        }
        private int powierzchnia()
        {
            return dlugosc * szerokosc;
        }
        public void Prezentuj()
        {
            Console.WriteLine("Obwod = " + obwod() + "\t" + "powierzchnia = " + powierzchnia());
        }
        public static int najwiekszy(Prostokat[] tab)
        {
            int najw = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i].powierzchnia() > najw)
                    najw = tab[i].powierzchnia();
            }
            return najw;
        }
        public static int max(Prostokat[] tab)
        {
            int najwieksze = 0;
            foreach (Prostokat a in tab)
            {
                int liczba = a.powierzchnia();
                if (liczba > najwieksze)
                {
                    najwieksze = liczba;
                }
            }
            return najwieksze;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat[] prost = new Prostokat[5];
            prost[0] = new Prostokat(3, 3);
            prost[1] = new Prostokat(3, 2);
            prost[2] = new Prostokat(4, 3);
            prost[3] = new Prostokat(4, 5);
            prost[4] = new Prostokat(2, 4);
            foreach (Prostokat x in prost)
            {
                x.Prezentuj();
            }
            Console.WriteLine($"Maksymalne pole wynosi: {Prostokat.max(prost)}");
        }
    }
}

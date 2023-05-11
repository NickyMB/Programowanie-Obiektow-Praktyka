using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Osoby
{
    public struct Osoba
    {
        public string Nazwisko, Imie;
        public Osoba(string Nazwisko, string Imie)
        {
            this.Nazwisko = Nazwisko;
            this.Imie = Imie;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            byte ile;
            Console.WriteLine("Ile osób będzie");
            ile = System.Convert.ToByte(Console.ReadLine());
            int i = 0;
            //string[,] tab = new string[ile, 2];
            List<Osoba> osobki = new List<Osoba>(ile);
            
            do
            {
                Console.WriteLine("Podaj nazisko");
                String Nazwisko_temp= Console.ReadLine();
                Console.WriteLine("Podaj imię");
                String Imie_Temp = Console.ReadLine();
                osobki.Add(new Osoba ( Nazwisko_temp, Imie_Temp ));
                i++;
            }
            while (i < ile);
            string kto;
            Console.WriteLine("Czyjego imienia szukasz");
            kto = Console.ReadLine();
            for (i = 0; i < ile; i++)
            {
                if (osobki[i].Nazwisko == kto)
                    Console.WriteLine(osobki[i].Imie);
            }
            Console.ReadKey();
        }
    }
}
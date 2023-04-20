using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kwadrat
{
    internal class Program
    {
        private static List<Kwadrat> listaK = new List<Kwadrat>();
        public static void Main(string[] args)
        {
            Kwadrat kwa1 = new Kwadrat(10, ConsoleColor.Blue);
            listaK.Add(kwa1);
            listaK.Add(new Kwadrat(2, ConsoleColor.Red));
            listaK.Add(new Kwadrat(3, ConsoleColor.Green));
            listaK.Add(new Kwadrat(4, ConsoleColor.Yellow));
            listaK.Add(new Kwadrat(5, ConsoleColor.White));
            rysowanie();
            Console.WriteLine($"Lista utworzonych kwadratów: {listaK.Count()}");
            Console.WriteLine($"Maksymalne pole wynosi: {Kwadrat.max_pole}");
            listaK.RemoveAt(0);
            rysowanie();
            Console.WriteLine($"Lista utworzonych kwadratów: {listaK.Count()}");
            Console.WriteLine($"Maksymalne pole wynosi: {Kwadrat.max_pole}");
            Console.ReadKey();
        }
        static void rysowanie()
        {
            Kwadrat.max_pole = 0;
            foreach (Kwadrat kwadrat in listaK)
            {
                kwadrat.RysujKwadrat();
            }
        }
    }
}

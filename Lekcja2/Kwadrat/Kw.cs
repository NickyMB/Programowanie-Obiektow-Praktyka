using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwadrat
{
    class Kwadrat
    {
        private int bok;
        public static int max_pole = 0;
        private ConsoleColor kolor;
        public Kwadrat(int Bok, ConsoleColor Kolor)
        {
            bok = Bok;
            kolor = Kolor;
        }
        public int Pole()
        {
            int x = bok * bok;
            if (x > max_pole)
                max_pole = x;
            return x;
        }
        public void RysujKwadrat()
        {
            Console.ForegroundColor = kolor;
            for (int i = 1; i <= bok; i++)
            {
                for (int j = 1; j <= bok; j++)
                    Console.Write("* ");
                Console.WriteLine("");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Pole());
            for (int i = 0; i <= 50; i++)
                Console.Write('-');
            Console.WriteLine("");
        }
        
    }
}

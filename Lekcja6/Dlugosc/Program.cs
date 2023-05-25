using Dlugosc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlugosc
{
    class Length
    {
        private int m, cm;
        public Length(int m, int cm)
        {
            this.m = m;
            this.cm = cm;
        }
        public static Length operator +(Length L1, Length L2)
        {
            Length L3 = new Length(0, 0);
            L3.m = L1.m + L2.m;
            L3.cm = L1.cm + L2.cm;
            if(L3.cm >= 100)
            {
                L3.m++;
                L3.cm -= 100;
            }
            return L3;
        }
        public static Length operator *(int mnoznik, Length Len)
        {
            Length L = new Length(0, 0);
            L.m = mnoznik * Len.m;
            L.cm = mnoznik * Len.cm;
            if (L.cm >=100)
            {
                L.m += L.cm / 100;
                L.cm = L.cm % 100;
            }
            return L;
        }
        public string GetLength()
        {
            return String.Format($"Length: {m} Metrów {cm} Centymetrów");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Length Len1 = new Length(4, 80);
            Length Len2 = new Length(2, 90);
            Length Len3 = new Length(3, 20);
            Length Len4 = Len1 + Len2 + Len3;
            Length Len5 = 3 * Len2;
            Console.WriteLine(Len1.GetLength());
            Console.WriteLine(Len2.GetLength());
            Console.WriteLine(Len3.GetLength());
            Console.WriteLine($"Suma: {Len4.GetLength()}");
            Console.WriteLine($"Iloczyn: {Len5.GetLength()}");
            Console.ReadKey();
        }
    }
}

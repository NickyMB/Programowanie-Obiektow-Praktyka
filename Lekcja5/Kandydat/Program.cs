using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kandydat
{
    public struct KandydatNaStudia
    {
        public string Nazwisko;
        public int punktyMatematyka,punktyInformatyka,punktyJezykObcy;
        public KandydatNaStudia(string n,int M,int I,int JO)
        {
            Nazwisko= n;
            punktyMatematyka= M;
            punktyInformatyka= I;
            punktyJezykObcy= JO;
        }
        public void ObliczPunkty()
        {
            Console.WriteLine($"{Nazwisko}  {(0.6 * punktyMatematyka) + (0.5*punktyInformatyka) +(0.2 * punktyJezykObcy)}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            KandydatNaStudia jeden = new KandydatNaStudia("Kowal", 55, 44, 22);
            KandydatNaStudia dwa = new KandydatNaStudia("Drwal", 22, 33, 44);
            KandydatNaStudia trzy = new KandydatNaStudia("Piekarz", 44, 11, 33);
            KandydatNaStudia cztery = new KandydatNaStudia("Stolarz", 33, 55, 22);
            KandydatNaStudia[] tab = { jeden,dwa,trzy,cztery };
            for (int i = 0; i < tab.Length; i++)
                tab[i].ObliczPunkty();
            Console.ReadLine();
        }
    }
}

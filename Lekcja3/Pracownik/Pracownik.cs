using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pracownik
{
    internal class Pracownik
    {
        protected string imie, nazwisko;
        protected double p_zadadnicza;
        public Pracownik(string nazwisko, string imie, double p_zasadnicza ) 
        { 
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.p_zadadnicza = p_zasadnicza;
        }
        public virtual double Premia()
        {
            return p_zadadnicza*0.2;
        }
        public void Wypisz()
        {
            Console.WriteLine($"{imie} {nazwisko} pensja: {p_zadadnicza}zł premia: {Premia()}zł");
        }
    } 
    internal class Kierownik : Pracownik
    {
        public Kierownik(string nazwisko, string imie, double p_zasadnicza) : base(nazwisko, imie, p_zasadnicza)
        {
        }
        public override double Premia()
        {
            return p_zadadnicza * 0.5;
        }
        public new void Wypisz()
        {
            base.Wypisz();
        }
    }
    internal class Dyrektor : Kierownik
    {
        public Dyrektor(string nazwisko, string imie, double p_zasadnicza) : base(nazwisko, imie, p_zasadnicza)
        { 
        }
        public override double Premia()
        {
            return base.Premia()+2000;
        }
        public new void Wypisz()
        {
            base.Wypisz();
        }
    } 
}

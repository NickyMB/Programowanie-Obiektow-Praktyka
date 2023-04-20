using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przestrzen
{
    internal class Prosta
    {
        protected double x;
        public Prosta(double x)
        {
            this.x = x;
        }
        public virtual void Odl_zero()
        {
            Console.WriteLine(Math.Abs(x));
        }   
    }
    internal class Plaszczyzna : Prosta
    {
        protected double y;
        public Plaszczyzna(double x,double y):base(x)
        {
            this.y = y;
        }
        public override void Odl_zero()
        {
            Console.WriteLine(Math.Sqrt(Math.Pow(0 - x, 2) + Math.Pow(0 - y,2)));
        }
    }
    internal class Przestrzen : Plaszczyzna
    {
        protected double z;
        public Przestrzen(double x,double y,double z):base(x,y)
        {
            this.z = z;
        }
        public override void Odl_zero()
        {
            Console.WriteLine(Math.Sqrt(Math.Pow(0 - x, 2) + Math.Pow(0 - y, 2) + Math.Pow(0-z,2)));
        }
        public static void Odl_punktow()
        {
            Console.WriteLine(Math.Sqrt(Math.Pow(0 - x, 2) + Math.Pow(0 - y, 2) + Math.Pow(0 - z, 2)));
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punkt
{
    internal class Punkt
    {
        private int x , y, xp, yp;
        public Punkt(int wsp_x, int wsp_y)
        {
            x = wsp_x;
            y = wsp_y;
        }
        public void Wyswielt()
        {
            Console.WriteLine($"x= {x} y= {y}");
        }
        public void Przesun(int dod_x, int dod_y)
        {
            xp = dod_x;
            yp = dod_y;
            x += dod_x;
            y += dod_y;
        }
        public void Cofnij_Przesun()
        {
            x -= xp;
            y -= yp;
        }
        public static double Odleglosc2punktuw(Punkt pun1, Punkt pun2)
        {
            return Math.Sqrt((pun1.x - pun2.x)* (pun1.x - pun2.x)+ (pun1.y - pun2.y)*(pun1.y - pun2.y));
        }
    }
}

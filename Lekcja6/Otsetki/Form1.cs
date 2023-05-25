using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otsetki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Oblicz_Click(object sender, EventArgs e)
        {
            double Wklad, Stopa, Odsetki, tmp;
            int Lat, Kap;
            Wklad = Convert.ToDouble(wklad.Text);
            Stopa = Convert.ToDouble(Stopa_o.Text);
            Lat = Convert.ToInt32(IlLat.Text);
            Kap = Convert.ToInt32(Kapitalizacja.Text);
            tmp = Wklad * Math.Pow((1 + Stopa / (100 * Kap)), Kap * Lat) - Wklad;
            tmp = Math.Round(tmp, 2);
            Output.Text = tmp.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsMVC
{
    public class TriangleModel
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double P { get; set; }

        public TriangleModel(string a, string b, string c)
        {
            A = Double.Parse(a);
            B = Double.Parse(b);
            C = Double.Parse(c);
        }

        public TriangleModel(string p)
        {
            P = Double.Parse(p);
            // запуск метода для расчета сторон исходя из периметра
        }

        public double Perimeter()
        {
            return Math.Round(A + B + C, 2);
        }

        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_uravnenie
{
    struct Uravnenie
    {
        double k;
        double b;
        public Uravnenie (double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            if (k==0, b==0)
            return "Решение - любое число";
            if (k==0, b!==0)
            return "Решений нет";
            double x = -b / k;
            return "Решение: х={x}";
        }
    }
}

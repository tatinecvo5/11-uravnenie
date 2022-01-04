using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_uravnenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение уравнения вида kx+b=0");
            Console.Write("Введите k=");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b=");
            double b = Convert.ToDouble(Console.ReadLine());
            /*if (k==0, b==0)
            {
                Console.WriteLine("Решение - любое число");
            }
            else 
                if (k==0, b!==0)
                }
        Console.WriteLine("Решений нет");
            }
            else 
    if (b!= 0)
        {
                                double x = -b / k;
    Console.WriteLine("Решение: х={x}");
        }*/
            Uravnenie uravnenie = new Uravnenie(k, b);
            Console.WriteLine(uravnenie.Root());
            Console.ReadKey();
        }
    }
}

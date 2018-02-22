using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
            

        {
            string aux;
            double a, r, V, S;
            const double pi = 3.1415926;
                Console.WriteLine("insira Altura ");
                aux = Console.ReadLine();
            a = Convert.ToDouble(aux);
            Console.WriteLine("Insira Raio");
            aux = Console.ReadLine();
            r = Convert.ToDouble(aux);
            V = pi * r * r * a;
            S = 2 * pi * r * (r + a);
            Console.WriteLine("V= " + V);
            Console.WriteLine("S= " + S);

        }
    }
}

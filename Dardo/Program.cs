using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dardo {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double primeira, segunda, terceira, maior;

            Console.WriteLine("Digite as tres distancias: ");
            primeira = double.Parse(Console.ReadLine(), CI);
            segunda = double.Parse(Console.ReadLine(), CI);
            terceira = double.Parse(Console.ReadLine(), CI);

            if (primeira > segunda && primeira > terceira) {
                maior = primeira;
            }
            else if (segunda > terceira) {
                maior = segunda;
            }
            else {
                maior = terceira;
            }

            Console.WriteLine("MAIOR DISTANCIA = " + maior.ToString("F2"), CI);
        }
    }
}

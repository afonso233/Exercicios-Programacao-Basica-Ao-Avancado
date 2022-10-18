using System;
using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            double A, B, C, X1, X2, DELTA;

            string[] v = Console.ReadLine().Split(' ');
            A = double.Parse(v[0], CultureInfo.InvariantCulture);
            B = double.Parse(v[1], CultureInfo.InvariantCulture);
            C = double.Parse(v[2], CultureInfo.InvariantCulture);

            DELTA = Math.Pow(B, 2.0) - 4 * A * C;


            if (DELTA < 0.0 || A == 0.0) {

                Console.WriteLine("Impossivel Calcular");
            }

            else {
                X1 = (-B + Math.Sqrt(DELTA)) / (2 * A);

                X2 = (-B - Math.Sqrt(DELTA)) / (2 * A);

                Console.WriteLine("R1 = " + X1.ToString("f5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + X2.ToString("f5", CultureInfo.InvariantCulture));
            }


            Console.ReadLine();

        }
    }
}

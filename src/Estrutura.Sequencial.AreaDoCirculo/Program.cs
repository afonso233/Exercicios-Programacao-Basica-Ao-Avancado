using System.Globalization;

namespace uri1002 {
    class Program {
        static void Main(string[] args) {
            double A, PI, raio;


            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            PI = 3.14159;

            A = PI * (Math.Pow(raio, 2));

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
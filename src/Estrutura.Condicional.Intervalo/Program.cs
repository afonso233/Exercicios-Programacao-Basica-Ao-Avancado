using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            double N;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (N < 0.0 || N > 100.0) {
                Console.WriteLine("Fora de intervalo");
            }

            else if (N <= 25.0) {
                Console.WriteLine("Intervalo [0,25]");
            }

            else if (N <= 50.0) {
                Console.WriteLine("Intervalo (25,50]");
            }

            else if (N <= 75.0) {
                Console.WriteLine("Intervalo (50,75]");
            }

            else {
                Console.WriteLine("Intervalo (75,100]");
            }
            Console.ReadLine();

        }
    }
}

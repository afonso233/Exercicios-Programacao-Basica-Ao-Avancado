using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int horas, km;
            double litros;

            horas = int.Parse(Console.ReadLine());
            km = int.Parse(Console.ReadLine());

            litros = (double)horas * km / 12;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}

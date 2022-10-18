using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            double volume, raio;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = (4.0 / 3) * 3.14159 * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("f3", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}

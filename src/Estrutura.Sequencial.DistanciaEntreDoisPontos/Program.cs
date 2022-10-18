using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {

            double x1, y1, x2, y2, distancia;

            string[] valores = Console.ReadLine().Split(' ');
            x1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            string[] valores2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(valores2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(valores2[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("f4", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
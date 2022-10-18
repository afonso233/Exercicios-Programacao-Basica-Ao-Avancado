using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int X;
            double Y, TOTAL;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            TOTAL = X / Y;

            Console.WriteLine(TOTAL.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

            Console.ReadLine();

        }
    }
}

using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            double Base, altura, area, perimetro, diagonal;

            Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = Base * altura;
            perimetro = 2 * Base + 2 * altura;
            diagonal = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(altura, 2));

            Console.WriteLine("AREA = " + area.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("f4", CultureInfo.InvariantCulture));


            Console.ReadLine();

        }
    }
}
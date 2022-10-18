using System.Globalization;

namespace uri1002 {
    class Program {
        static void Main(string[] args) {
            double area, preço, comprimento, largura, valorMetroQuadrado;

            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preço = valorMetroQuadrado * area;

            Console.WriteLine("AREA = " + area.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("PREÇO = " + preço.ToString("f2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}

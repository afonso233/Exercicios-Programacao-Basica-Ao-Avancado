using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            double nota1, nota2, media;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media < 60.0) {
                Console.WriteLine("REPROVADO");
            }

            Console.ReadLine();

        }
    }
}

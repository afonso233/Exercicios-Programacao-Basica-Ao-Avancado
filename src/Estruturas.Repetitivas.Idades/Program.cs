using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int idade, quantidade;
            double soma, media;

            idade = int.Parse(Console.ReadLine());
            soma = 0.0;
            quantidade = 0;

            while (idade > 0) {
                quantidade = quantidade + 1;
                soma = soma + idade;
                idade = int.Parse(Console.ReadLine());
            }

            media = soma / quantidade;

            Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));


            Console.ReadLine();
        }
    }
}

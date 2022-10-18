using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int codigo, quantidade;
            double total;

            string[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0], CultureInfo.InvariantCulture);
            quantidade = int.Parse(vet[1], CultureInfo.InvariantCulture);

            if (codigo == 1) {
                total = quantidade * 4.0;
            }

            else if (codigo == 2) {
                total = quantidade * 4.50;
            }

            else if (codigo == 3) {
                total = quantidade * 5.0;
            }

            else if (codigo == 4) {
                total = quantidade * 2.0;
            }

            else {
                total = quantidade * 1.50;
            }

            Console.WriteLine("TOTAL R$ = " + total.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}

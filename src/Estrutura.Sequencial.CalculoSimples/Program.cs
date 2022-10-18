using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int codigoDaPeca1, numeroDePecas1, codigoDaPeca2, numeroDePecas2;
            double valorDeCadaPecas1, valorDeCadaPecas2, valor;

            string[] vet = Console.ReadLine().Split(' ');
            codigoDaPeca1 = int.Parse(vet[0]);
            numeroDePecas1 = int.Parse(vet[1]);
            valorDeCadaPecas1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            codigoDaPeca2 = int.Parse(vet2[0]);
            numeroDePecas2 = int.Parse(vet2[1]);
            valorDeCadaPecas2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            valor = numeroDePecas1 * valorDeCadaPecas1 + numeroDePecas2 * valorDeCadaPecas2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));




            Console.ReadLine();

        }
    }
}
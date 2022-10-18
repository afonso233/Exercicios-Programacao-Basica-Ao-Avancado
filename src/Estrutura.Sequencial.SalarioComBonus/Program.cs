using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            string nome;
            double salario, vendas, total;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = (vendas * 15) / 100 + salario;

            Console.WriteLine("TOTAL = R$ " + total.ToString("f2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}

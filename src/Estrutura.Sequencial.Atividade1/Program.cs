using System.Globalization;

namespace uri1002 {
    class Program {
        static void Main(string[] args) {
            string nomeCompleto = Console.ReadLine();
            int quartos = int.Parse(Console.ReadLine());
            double preço = double.Parse(Console.ReadLine());

            string[] v = Console.ReadLine().Split(' ');
            string ultimoNome = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2]);

            Console.WriteLine("Entre com seu nome completo " + nomeCompleto);
            Console.WriteLine("Qauntos quartos tem na sua casa " + quartos);
            Console.WriteLine("Entre com o preço de um produto " + preço.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Entre com seu ultimo nome, idade e altura ");
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("f2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}

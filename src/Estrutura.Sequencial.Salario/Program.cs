using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int numero, horas;
            double valorhora, salario;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            salario = valorhora * horas;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();

        }
    }
}

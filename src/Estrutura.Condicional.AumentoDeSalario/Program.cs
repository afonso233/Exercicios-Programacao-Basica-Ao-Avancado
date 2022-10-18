namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            double salario, reajuste, novosalario, percentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400) {
                percentual = 15;
                reajuste = salario * 15 / 100;
                novosalario = reajuste + salario;

            }

            else if (salario <= 800) {
                percentual = 12;
                reajuste = salario * 12 / 100;
                novosalario = reajuste + salario;
            }
            else if (salario <= 1200) {
                percentual = 10;
                reajuste = salario * 10 / 100;
                novosalario = reajuste + salario;
            }

            else if (salario <= 2000) {
                percentual = 7;
                reajuste = salario * 7 / 100;
                novosalario = reajuste + salario;
            }

            else {
                percentual = 4;
                reajuste = salario * 4 / 100;
                novosalario = reajuste + salario;
            }

            Console.WriteLine("Novo salario: " + novosalario.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual + " %");

            Console.ReadLine();

        }
    }
}

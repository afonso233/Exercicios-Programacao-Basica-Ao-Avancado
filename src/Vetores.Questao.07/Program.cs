using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int N;
            string[] nomes;
            double[] notas1;
            double[] notas2;

            N = int.Parse(Console.ReadLine());

            nomes = new string[N];
            notas1 = new double[N];
            notas2 = new double[N];

            for (int i = 0; i < N; i++) {
                string[] x = Console.ReadLine().Split(' ');
                nomes[i] = x[0];
                notas1[i] = double.Parse(x[1], CultureInfo.InvariantCulture);
                notas2[i] = double.Parse(x[2], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Alunos aprovados: ");
            for (int i = 0; i < N; i++) {
                double soma = notas1[i] + notas2[i];
                double media = soma / 2;

                if (media >= 6) {
                    Console.WriteLine(nomes[i]);
                }
            }

            Console.ReadLine();
        }
    }
}






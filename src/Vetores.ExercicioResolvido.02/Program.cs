using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int i, N;

            double[] vetor;

            N = int.Parse(Console.ReadLine());

            vetor = new double[N];

            string[] x = Console.ReadLine().Split(' ');
            for (i = 0; i < N; i++) {
                vetor[i] = double.Parse(x[i], CultureInfo.InvariantCulture);
            }
            for (i = 0; i < N; i++) {
                Console.Write(vetor[i].ToString("f1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            double soma;
            soma = 0;

            for (i = 0; i < N; i++) {
                soma = soma + vetor[i];

            }

            double media = soma / N;

            Console.WriteLine(soma.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}



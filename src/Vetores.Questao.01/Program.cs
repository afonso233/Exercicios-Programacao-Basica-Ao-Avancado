using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int N;
            double[] valores;

            N = int.Parse(Console.ReadLine());

            valores = new double[N];

            string[] x = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                valores[i] = double.Parse(x[i], CultureInfo.InvariantCulture);
            }

            double maior = valores[0];
            int posicaoMaior = 0;
            for (int i = 1; i < N; i++) {
                if (valores[i] > maior) {
                    maior = valores[i];
                    posicaoMaior = i;
                }
            }

            Console.WriteLine(maior.ToString("f1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicaoMaior);

            Console.ReadLine();
        }
    }
}





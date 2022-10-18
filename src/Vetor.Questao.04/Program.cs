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



            double soma = 0;
            for (int i = 0; i < N; i++) {
                soma = soma + valores[i];
            }
            double media;
            media = (double)soma / N;
            Console.WriteLine(media.ToString("f3", CultureInfo.InvariantCulture));

            for (int i = 0; i < N; i++) {
                if (valores[i] < media) {
                    Console.WriteLine(valores[i].ToString("f1", CultureInfo.InvariantCulture));
                }
            }

            Console.ReadLine();
        }
    }
}





using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int N;
            int[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new int[N];

            string[] x = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                vet[i] = int.Parse(x[i]);
            }

            int soma = 0;
            int contar = 0;
            for (int i = 0; i < N; i++) {
                if (vet[i] % 2 == 0) {
                    soma = soma + vet[i];
                    contar++;
                }
            }
            double media;
            media = (double)soma / contar;
            Console.WriteLine(media.ToString("f1", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}






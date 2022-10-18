using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int N;
            double[] alturas;
            char[] sexos;

            N = int.Parse(Console.ReadLine());
            alturas = new double[N];
            sexos = new char[N];

            for (int i = 0; i < N; i++) {
                string[] x = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(x[0], CultureInfo.InvariantCulture);
                sexos[i] = char.Parse(x[1]);
            }

            double MenorAltura = alturas[0];
            for (int i = 1; i < N; i++) {
                if (alturas[i] < MenorAltura) {
                    MenorAltura = alturas[i];
                }
            }
            Console.WriteLine("Menor altura: " + MenorAltura.ToString("f2", CultureInfo.InvariantCulture));

            double MaiorAltura = alturas[0];
            for (int i = 1; i > N; i++) {
                if (alturas[i] > MaiorAltura) {
                    MaiorAltura = alturas[i];
                }
            }
            Console.WriteLine("Maior altura: " + MaiorAltura.ToString("f2", CultureInfo.InvariantCulture));

            double soma = 0;
            int ContMulheres = 0;
            for (int i = 0; i < N; i++) {
                if (sexos[i] == 'F') {
                    soma = soma + alturas[i];
                    ContMulheres++;
                }
            }

            if (ContMulheres == 0) {
                Console.WriteLine("Não há nenhuma mulher dentre essas pessoas");
            }
            else {
                double media = soma / ContMulheres;
                Console.WriteLine("Media da altura das mulheres: " + media.ToString("f2", CultureInfo.InvariantCulture));
            }


            int ContHomens = 0;
            for (int i = 0; i < N; i++) {
                if (sexos[i] == 'M') {
                    ContHomens++;
                }
            }

            if (ContHomens == 0) {
                Console.WriteLine("Não há nenhum homem dentre essas pessoas");
            }
            else {
                Console.WriteLine("Numero de homens: " + ContHomens);
            }

            Console.ReadLine();
        }
    }
}





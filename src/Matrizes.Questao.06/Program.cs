using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int N;
            double[,] mat;

            N = int.Parse(Console.ReadLine());

            mat = new double[N, N];

            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++) {
                    mat[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }
            // SOMA DOS POSTIVOS
            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());

            double soma = 0.0;
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (mat[i, j] > 0.0) {
                        soma = soma + mat[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSIIVOS: " + soma.ToString("f1", CultureInfo.InvariantCulture));

            // LINHA ESCOLHIDA
            Console.Write("LINHA ESCOLHIDA: ");
            for (int j = 0; j < N; j++) {
                Console.Write(mat[linha, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            // COLUNA ESCOLHIDA
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++) {
                Console.Write(mat[coluna, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            // ELEMENTOS DA DIAGONAL PRINCIPAL
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++) {
                Console.Write(mat[i, i].ToString("f1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            // MATRIZ ALTERADA ELEVANDO OS NEGATIVOS AO QUADRADO
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (mat[i, j] < 0.0) {
                        mat[i, j] = mat[i, j] * mat[i, j];
                    }
                }
            }
            Console.WriteLine("MATRIZ ALTERADA: ");

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(mat[i, j].ToString("f1", CultureInfo.InvariantCulture) + " ");

                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}





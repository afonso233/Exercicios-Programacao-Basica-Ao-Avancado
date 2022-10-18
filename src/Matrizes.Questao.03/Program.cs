namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int N;
            int[,] A;

            N = int.Parse(Console.ReadLine());

            A = new int[N, N];

            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(s[j]);
                }
            }



            for (int i = 0; i < N; i++) {
                int maior = A[i, 0];
                for (int j = 1; j < N; j++) {
                    if (A[i, j] > maior) {
                        maior = A[i, j];
                    }

                }
                Console.WriteLine(maior);
            }

            Console.ReadLine();
        }
    }
}




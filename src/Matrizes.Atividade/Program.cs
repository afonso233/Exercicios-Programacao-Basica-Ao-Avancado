namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int N, M;
            int[,] A;

            string[] s = Console.ReadLine().Split(' ');
            N = int.Parse(s[0]);
            M = int.Parse(s[1]);

            A = new int[N, M];

            for (int i = 0; i < N; i++) {
                string[] x = Console.ReadLine().Split(' ');

                for (int j = 0; j < M; j++) {
                    A[i, j] = int.Parse(x[j]);
                }
            }

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < M; j++) {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}




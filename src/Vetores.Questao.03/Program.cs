namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int N;
            int[] A;
            int[] B;

            N = int.Parse(Console.ReadLine());

            A = new int[N];
            B = new int[N];

            string[] x = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                A[i] = int.Parse(x[i]);
            }

            x = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                B[i] = int.Parse(x[i]);
            }

            int[] c = new int[N];
            for (int i = 0; i < N; i++) {
                c[i] = A[i] + B[i];

            }

            for (int i = 0; i < N; i++) {
                Console.Write(c[i] + " ");
            }


            Console.ReadLine();
        }
    }
}





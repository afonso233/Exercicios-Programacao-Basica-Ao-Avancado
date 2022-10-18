namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int N;
            int[] valores;

            N = int.Parse(Console.ReadLine());
            valores = new int[N];

            string[] x = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                valores[i] = int.Parse(x[i]);
            }

            int contar = 0;
            for (int i = 0; i < N; i++) {
                if (valores[i] % 2 == 0) {
                    Console.Write(valores[i] + " ");

                    contar++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(contar);
            Console.ReadLine();
        }
    }
}





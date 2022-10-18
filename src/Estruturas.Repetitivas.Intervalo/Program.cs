namespace uri1000 {
    class Program {
        static void Main(string[] args) {

            int N, somaIN, somaOUT;
            N = int.Parse(Console.ReadLine());

            somaIN = 0;
            somaOUT = 0;

            for (int i = 0; i < N; i++) {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) {
                    somaIN = somaIN + 1;
                }
                else {
                    somaOUT = somaOUT + 1;

                }
            }

            Console.WriteLine(somaIN + " in");
            Console.WriteLine(somaOUT + " out");


            Console.ReadLine();

        }

    }
}
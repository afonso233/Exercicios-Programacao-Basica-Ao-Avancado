namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int N;
            string[] nomes;
            int[] idades;

            N = int.Parse(Console.ReadLine());
            nomes = new string[N];
            idades = new int[N];


            for (int i = 0; i < N; i++) {
                string[] x = Console.ReadLine().Split(' ');
                nomes[i] = x[0];
                idades[i] = int.Parse(x[1]);
            }

            int maior = idades[0];
            int posMaior = 0;
            for (int i = 1; i < N; i++) {
                if (idades[i] > maior) {
                    maior = idades[i];
                    posMaior = i;
                }
            }
            Console.WriteLine("Pessoa mais velha: " + nomes[posMaior]);


            Console.ReadLine();
        }
    }
}





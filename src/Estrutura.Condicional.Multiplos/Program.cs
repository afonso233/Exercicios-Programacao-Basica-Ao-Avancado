namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int A, B;

            string[] v = Console.ReadLine().Split(' ');
            A = int.Parse(v[0]);
            B = int.Parse(v[1]);

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("Sao Multiplos");
            }

            else {
                Console.WriteLine("Nao sao Multiplos");
            }

            Console.ReadLine();

        }
    }
}

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int a, b, c;

            string[] v = Console.ReadLine().Split(' ');
            a = int.Parse(v[0]);
            b = int.Parse(v[1]);
            c = int.Parse(v[2]);

            if (a < b && a < c) {
                Console.WriteLine(" MENOR = " + a);
            }

            else if (b < c) {
                Console.WriteLine("MENOR = " + b);
            }

            else {
                Console.WriteLine("MENOR = " + c);
            }
            Console.ReadLine();

        }
    }
}

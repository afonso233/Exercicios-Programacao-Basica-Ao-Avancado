namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int n, i, mutiplicaçao;



            n = int.Parse(Console.ReadLine());


            for (i = 1; i <= 10; i++) {

                int resultado = i * n;
                Console.WriteLine(i + " x " + n + " = " + resultado);
            }


            Console.ReadLine();
        }
    }
}

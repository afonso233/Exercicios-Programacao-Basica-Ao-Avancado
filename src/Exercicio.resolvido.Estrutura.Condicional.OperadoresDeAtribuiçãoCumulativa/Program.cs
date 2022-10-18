namespace uri1000 {
    class Program {
        static void Main(string[] args) {

            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;

            if (minutos > 100) {
                conta += (minutos - 100) * 2;
            }

            Console.WriteLine("Valor a pagar: R$ " + conta);

            Console.ReadLine();

        }
    }
}

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int a, b, c, maior, MaiorAB;

            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            MaiorAB = (a + b + Math.Abs(a - b)) / 2;

            maior = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;

            Console.WriteLine(maior + " eh o maior");


            Console.ReadLine();




        }
    }
}

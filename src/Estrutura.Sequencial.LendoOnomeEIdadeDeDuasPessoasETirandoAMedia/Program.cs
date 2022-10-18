using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            string nome1, nome2;
            int idade1, idade2;
            double media;

            string[] v = Console.ReadLine().Split(' ');
            nome1 = v[0];
            idade1 = int.Parse(v[1]);


            string[] v2 = Console.ReadLine().Split(' ');
            nome2 = v2[0];
            idade2 = int.Parse(v2[1]);

            media = (double)(idade1 + idade2) / 2;

            Console.WriteLine("A idade media de " + nome1 + " e " + nome2 + " é de " + media.ToString("f1", CultureInfo.InvariantCulture) + " anos ");






            Console.ReadLine();

        }
    }
}

using System;
using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int N;

            string[] nomes;
            int[] idades;
            double[] alturas;

            N = int.Parse(Console.ReadLine());

            nomes = new string[N];
            idades = new int[N];
            alturas = new double[N];


            for (int i = 0; i < N; i++) {
                string[] v = Console.ReadLine().Split(' ');
                nomes[i] = v[0];
                idades[i] = int.Parse(v[1]);
                alturas[i] = double.Parse(v[2], CultureInfo.InvariantCulture);
            }

            double soma, media;
            soma = 0.0;
            for (int i = 0; i < N; i++) {
                soma = soma + alturas[i];

            }
            media = soma / N;
            Console.WriteLine("Altura média: " + media.ToString("f2", CultureInfo.InvariantCulture));

            int contar;
            contar = 0;
            for (int i = 0; i < N; i++) {

                if (idades[i] < 16) {
                    contar++;
                }
            }
            double porcentagem;
            porcentagem = (double)100.0 * contar / N;

            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("f1", CultureInfo.InvariantCulture) + "%");

            Console.ReadLine();
        }
    }
}






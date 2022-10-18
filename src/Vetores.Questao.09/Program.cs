using System.Globalization;

namespace uri1000 {
    class Program {
        static void Main(string[] args) {
            int N;
            string[] produto;
            double[] PrecoCompra;
            double[] PrecoVenda;

            N = int.Parse(Console.ReadLine());

            produto = new string[N];
            PrecoCompra = new double[N];
            PrecoVenda = new double[N];

            for (int i = 0; i < N; i++) {
                string[] x = Console.ReadLine().Split(' ');
                produto[i] = x[0];
                PrecoCompra[i] = double.Parse(x[1], CultureInfo.InvariantCulture);
                PrecoVenda[i] = double.Parse(x[2], CultureInfo.InvariantCulture);
            }

            int ContAbaixode10 = 0;
            int ContEntre10e20 = 0;
            int ContAcimade20 = 0;
            for (int i = 0; i < N; i++) {
                double lucro = PrecoVenda[i] - PrecoCompra[i];
                double PorcentagemDoLucro = lucro / PrecoCompra[i] * 100;

                if (PorcentagemDoLucro < 10.0) {
                    ContAbaixode10++;
                }
                else if (PorcentagemDoLucro <= 20) {
                    ContEntre10e20++;
                }
                else {
                    ContAcimade20++;
                }
            }

            Console.WriteLine("Lucro abaixo de 10% : " + ContAbaixode10);
            Console.WriteLine("Lucro entre 10% e 20%: " + ContEntre10e20);
            Console.WriteLine("Lucro acima de 20%: " + ContAcimade20);

            double SomaDasCompras = 0;
            double SomaDasVendas = 0;
            for (int i = 0; i < N; i++) {
                SomaDasCompras = SomaDasCompras + PrecoCompra[i];
                SomaDasVendas = SomaDasVendas + PrecoVenda[i];
            }
            double LucroTotal = SomaDasVendas - SomaDasCompras;

            Console.WriteLine("Valor total de compras: " + SomaDasCompras.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de vendas: " + SomaDasVendas.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + LucroTotal.ToString("f2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}






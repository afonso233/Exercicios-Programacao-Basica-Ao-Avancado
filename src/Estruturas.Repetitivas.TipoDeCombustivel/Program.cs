namespace uri1000 {
    class Program {
        static void Main(string[] args) {

            int combustivel, alcool, gasolina, disel;
            combustivel = int.Parse(Console.ReadLine());

            alcool = 0;
            gasolina = 0;
            disel = 0;
            while (combustivel != 4) {
                if (combustivel == 1) {
                    alcool = alcool + 1;
                }

                else if (combustivel == 2) {
                    gasolina = gasolina + 1;
                }

                else if (combustivel == 3) {
                    disel = disel + 1;
                }

                combustivel = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Disel: " + disel);
            Console.ReadLine();
        }
    }
}

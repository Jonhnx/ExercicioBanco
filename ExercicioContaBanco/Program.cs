using System;
using System.Globalization;

namespace ExercicioContaBanco {
    class Program {
        static void Main(string[] args) {
            ContaBancaria Nova;
            Console.Write("Entre com o número da conta : ");
            int NC = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta : ");
            string TC = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            char DI = char.Parse(Console.ReadLine());

            while (DI != 'n' && DI != 'N' && DI != 's' && DI != 'S') {
                Console.WriteLine("Digite Sim[s/S] ou Não[n/N]! : ");
                DI = char.Parse(Console.ReadLine());
            }
            if (DI == 's' || DI == 'S') {
                Console.WriteLine("Entre um valor para deposito inicial : ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Nova = new ContaBancaria(NC, TC, depositoInicial);
            } else{
                Nova = new ContaBancaria(NC, TC); 
            }

            Console.WriteLine("\nDados da conta : " + Nova + "\n");

            Console.Write("\nEntre com um valor para deposito : ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Nova.Deposito(deposito);

            Console.WriteLine("\nDados da conta atualizados : " + Nova);

            Console.Write("\nEntre com um valor para saque : ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Nova.Saque(saque);

            Console.WriteLine("\nDados da conta atualizados : " + Nova);


        }
    }
}

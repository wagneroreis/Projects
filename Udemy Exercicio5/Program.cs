using System;
using System.Globalization;
namespace Exercicio5 {
    class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet[0]);
            int qte1 = int.Parse(vet[1]);
            double valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet[0]);
            int qte2 = int.Parse(vet[1]);
            double valor2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double soma = valor1 * qte1 + valor2 * qte2;

            Console.WriteLine("VALOR A PAGAR: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}

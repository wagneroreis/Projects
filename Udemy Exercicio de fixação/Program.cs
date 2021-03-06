using System;
using System.Globalization;

namespace Teste2 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int casa = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string segundonome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = Double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(casa);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(segundonome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

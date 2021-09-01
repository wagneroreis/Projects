using System;
using System.Globalization;

namespace Curso {
    class Program {
        static void Main(string[] args)  {

            string nome;
            double salario, totalv;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalv = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalv = salario + totalv * 0.15;

            Console.WriteLine("TOTAL = R$" + totalv.ToString("F2",CultureInfo.InvariantCulture));




        }
    }
}
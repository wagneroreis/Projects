﻿using System;

namespace Wagner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estrutura condicional

            int horas;

            Console.WriteLine("Quantas Horas? ");
            horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (horas < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");


            }
    }
}

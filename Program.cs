// See https://aka.ms/new-console-template for more information
using System;

namespace TabelaRegioes
{
    class Program
    {
        static void Main (string[] args)
        {
        // Entrada de dados
        Console.WriteLine("Qual é o seu nome?");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}.");

        Console.WriteLine("Porfavor, digite qual é o código entre 1 a 5:");
        int codigo = int.Parse(Console.ReadLine());

        Console.WriteLine("Agora digite o valor base: ");
        float valor = float.Parse(Console.ReadLine());

        switch (codigo)
        {
            case 1 :
            Console.WriteLine($"Sudeste, {valor}");
            return;

            case 2 :
            Console.WriteLine("Sul, " + valor * 1.1);
            return;

            case 3 :
            Console.WriteLine("Centro-Oeste, " + valor * 1.2);
            return;

            case 4 :
            Console.WriteLine("Nordeste, " + valor * 1.3);
            return;

            case 5 :
            Console.WriteLine("Norte, " + valor * 1.4);
            return;
           }
        }
    }
}

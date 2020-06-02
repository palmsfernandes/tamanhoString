using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamanhoString1
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string frase2;
            int tamanho;
            int tamanho1;

            Console.Write("Digite uma frase: ");
            frase = Console.ReadLine();

            Console.Write("Digite outra frase: ");
            frase2 = Console.ReadLine();

            tamanho = frase.Length;
            tamanho1 = frase2.Length;

            if (tamanho == tamanho1)
                Console.WriteLine("As duas frase são de tamanhos iguais!");
            else
                Console.WriteLine("As duas frases são de tamanhos diferentes");

            if (frase == frase2)
                Console.WriteLine("As duas frase tem os mesmos conteudos");
            else
                Console.WriteLine("As duas frases tem contudo diferentes");

            Console.ReadLine();

        }
    }
}

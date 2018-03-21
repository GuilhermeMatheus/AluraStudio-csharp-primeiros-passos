using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 2-CriandoVariaveis . . .");

            int idade;
            idade = 32;

            Console.WriteLine(idade);

            idade = 15;
            Console.WriteLine(idade);

            idade = 20 + 3;
            Console.WriteLine(idade);

            idade = 20 + 3 * 2;
            Console.WriteLine(idade);

            idade = (20 + 3) * 2;
            Console.WriteLine("(20 + 3) * 2 = " + idade);

            Console.WriteLine("Execução finalizada. Tecle enter para sair . . .");
            Console.ReadLine();
        }
    }
}

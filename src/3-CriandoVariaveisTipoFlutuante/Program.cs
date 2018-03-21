using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisTipoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 3 CriandoVariaveisTipoFlutuante");

            double salario;
            salario = 1200.50;

            Console.WriteLine(salario);

            double idade;
            idade = 31.0 / 2;
            Console.WriteLine(idade);

            double novaIdade;
            novaIdade = 5.0 / 3;
            Console.WriteLine(novaIdade);

            int outraIdade = 5;
            Console.Write(outraIdade);

            Console.WriteLine("A aplicação finalizou. Tecle enter para sair . . . ");
            Console.ReadLine();
        }
    }
}

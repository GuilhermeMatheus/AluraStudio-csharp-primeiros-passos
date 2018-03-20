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
            Console.WriteLine("Projeto 2-CriandoVariaveis em execução...");

            int anoCriacaoCSharp;
            anoCriacaoCSharp = 2002;

            Console.WriteLine(anoCriacaoCSharp);

            int variavelTeste;
            variavelTeste = 10;
            Console.WriteLine(variavelTeste);
            variavelTeste = 10 + 5;
            Console.WriteLine(variavelTeste);
            variavelTeste = 10 + 5 * 2;
            Console.WriteLine(variavelTeste);

            variavelTeste = (10 + 5) * 2;
            // Aqui estamos montando uma mensagem com o uso do Console.Write e o Console.WriteLine
            Console.Write("(10 + 5) * 2 = "); // O Write escreve na tela e não pula a linha
            Console.WriteLine(variavelTeste); // O WriteLine escreve na tela e pula a linha

            Console.WriteLine("(10 + 5) * 2 = " + variavelTeste); // Podemos também concatenar textos e numéricos do tipo inteiro (int)

            Console.WriteLine("Finalizada a execução. Dê enter para encerrar o processo...");
            Console.ReadLine();
        }
    }
}

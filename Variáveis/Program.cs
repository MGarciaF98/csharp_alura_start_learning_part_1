using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variáveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Variáveis");
            int idade = 32;
            Console.WriteLine(idade);

            double pontos;
            //Se os fatores forem int, o resultado atribuído será int, ignorando o resto da divisão.
            pontos = 10 / 3;
            Console.WriteLine(pontos);
            //Para o resultado ser um double, pelo menos um dos fatores deve ser um double.
            pontos = 10.0 / 3;
            Console.WriteLine(pontos);


            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}

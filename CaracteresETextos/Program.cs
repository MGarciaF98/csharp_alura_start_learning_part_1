using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 - Caracteres e textos");

            ///Character sempre entre ''. 
            ///String sempre entre "".

            //character
            //Não pode receber valor vazio ''
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            //Ao atribuir um número inteiro para um 'char' ele atribui o símbolo correspondente respeitando a tabela ASCII.

            primeiraLetra = (char)64;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 2);
            Console.WriteLine(primeiraLetra);

            string titulo = "Estou escrevendo variáveis de texto";
            string cursosProgramacao =
@" - .NET
 - Java
 - Javascript";
            Console.WriteLine(cursosProgramacao);



            Console.ReadLine();
        }
    }
}

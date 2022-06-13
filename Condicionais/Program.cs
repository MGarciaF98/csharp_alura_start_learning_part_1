using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - Condicionais");

            int idateJoao = 16;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado)
            {
                mensagemAdicional = "João está acompanhado";
            }
            else
            {
                mensagemAdicional = "João não está acompanhado";
            }

            if (idateJoao >= 18)
            {
                Console.WriteLine("João não possui mais de 18 anos");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João é maior de idade");
                Console.WriteLine(mensagemAdicional);
            }



            Console.ReadLine();
        }
    }
}

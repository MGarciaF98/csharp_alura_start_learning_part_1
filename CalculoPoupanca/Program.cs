using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 6 - While");

            double valorInvestido = 1000.0;

            double rendimento = 0.0036;

            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * rendimento;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
                contadorMes++;

            }

            Console.ReadLine();
        }
    }
}

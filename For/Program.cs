using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - For");


            double valorInvestido = 1000.0;

            double rendimento = 1.0036;

            bool investirApenasMeioAno = true;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {

                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    if (investirApenasMeioAno && contadorMes > 6)
                    {
                        break;
                    }
                    valorInvestido = valorInvestido * rendimento;
                    Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
                }
                rendimento += 0.0001;
                Console.WriteLine("Após " + contadorAno + " ano(s), você terá R$" + valorInvestido);

            }


            Console.ReadLine();
        }
    }
}

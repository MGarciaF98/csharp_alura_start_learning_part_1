using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Conversoes e outros tipos numéricos");

            double salario = 1200.50;

            ///Conversão de double para inteiro. Perderá a precisão decimal, e deve ser destacado essa conversão (Cast) da maneira abaixo:
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            /// int é um tipo numérico para números inteiros. (32 bits)
            int idadeInt = 1400000;

            /// long é um tipo numérico para números inteiros, porém suporta números maiores do que o int. (64 bits)
            long idadeLong = 14000000000;

            /// short é um tipo numérico para números inteiros, porém suporta números menores do que o int. (32 bits)
            short idadeShort = 14000;


            double salarioDouble = 15.9;

            /// float possui uma precisão inferior ao double depois da casa decimal. Deve ser inserido o sufixo 'f'.
            float salarioFloat = 15.9f;



            Console.ReadLine();

        }
    }
}

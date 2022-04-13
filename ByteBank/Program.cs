using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado  = Metodo();

            if (resultado == -2) 
                Console.WriteLine("Ocorreu um erro!");

            Console.ReadLine();
        }

        /// Teste com a cadeia de chamada:
        /// Metodo -> TestaDivisao -> Dividir
        private static int Metodo()
        {
            int resultadoDivisao = TestaDivisao(0);

            if (resultadoDivisao == -2) return -2;

            int resultado2 = TestaDivisao(20);

            if(resultado2 == -2) return -2;

            return 0;
        }

        private static int TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            if (resultado == -2) return -2;
            
            if (resultado == -1)
            {
                Console.WriteLine("Não é possivel fazer divisão por 0");
            } 
            else
            {
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }

            return 0;
        }

        private static int Dividir(int numero, int divisor)
        {
            if(divisor == 0)
            {
                return -1;
            }

            if(divisor > numero)
            {
                return -2;
            }

            return numero / divisor;
        }

    }
}

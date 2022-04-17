using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(456, 789684);
                ContaCorrente conta2 = new ContaCorrente(789, 456794);

                conta1.Transferir(10000, conta2);
            }            
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da Inner Exception (exceção interna): ");
                Console.WriteLine(e.InnerException);
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        /// Teste com a cadeia de chamada:
        /// Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                Dividir(10, divisor);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Fui capturado pelo (NullReferenceException ex)");
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fui capturado pelo (Exception ex)");
                Console.WriteLine(ex.StackTrace);
            }


            //int resultado = Dividir(10, divisor);
            //Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Exceção com numero={numero} e divisor={divisor}");
                throw;
            }

        }

    }
}

using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                ContaCorrente conta = new ContaCorrente(456, 4578420);

                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(50);

                conta.Sacar(500);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argumento com problema: " + e.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException"); 
                Console.WriteLine(e.Message);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Metodo();

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

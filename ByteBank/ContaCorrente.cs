using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }
        public Cliente Titular { get; set; }

        public int Numero { get; }
        public int Agencia { get; }

        private double _saldo = 100;
        public double Saldo
        {
            get { return _saldo; }

            set
            {
                if (value < 0)
                    return; //Para de executar o método, e devolve o fluxo do programa.

                _saldo = value;
            }
        }



        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
                throw new ArgumentException("O argumento agencia deve ser maior que 0", nameof(agencia));

            if (numero <= 0)
                throw new ArgumentException("O argumento numero deve ser maior que 0", nameof(numero));

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }



        public void Sacar(double valor)
        {
            if (_saldo < valor)           
                throw new SaldoInsuficienteException("Saldo insuficiente para o saqe no valor de " + valor);

            _saldo -= valor;            
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente constaDestino)
        {
            if (_saldo < valor)
                return false;

            _saldo -= valor;
            constaDestino.Depositar(valor);
            return true;
        }
    }
}


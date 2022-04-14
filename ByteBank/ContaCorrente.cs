
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
            Agencia = agencia;
            Numero = numero;

            TaxaOperacao = 30 / TotalDeContasCriadas;

            TotalDeContasCriadas++;
        }



        public bool Sacar(double valor)
        {
            if (_saldo < valor)
                return false;

            _saldo -= valor;
            return true;
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


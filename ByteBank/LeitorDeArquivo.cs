using System;
using System.IO;

namespace ByteBank
{
    public class LeitorDeArquivo : IDisposable
    {
        public string Arqiuvo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arqiuvo = arquivo;

            //throw new FileNotFoundException();

            Console.WriteLine("Abrindo arquivo: " + arquivo);                
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha. . .");

            throw new IOException();

            return "Linha do arquivo";                
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo.");
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}

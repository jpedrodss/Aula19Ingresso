using System;

namespace Aula19Ingresso
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVIP ticket = new IngressoVIP();
            ticket.Valor = 15f;
            ticket.ValorAdicional = 5f;

            ticket.ImprimirValor();
            ticket.MostrarValorVIP();

            System.Console.WriteLine($"O valor de diferença entre o Ingresso comum e Ingresso VIP é de R${ticket.ValorAdicional}.");
        }
    }
}

namespace Aula19Ingresso
{
    public class Ingresso
    {
        public float Valor {get; set; }

        public void ImprimirValor(){
            System.Console.WriteLine($"Valor do ingresso comum é de R${Valor}.");
        }
    }
}
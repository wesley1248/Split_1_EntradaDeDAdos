using System;

namespace MetodoSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaraçao das variaveis
            string nome;
            int idade;
            double altura;

            //Uso do metodo split, Solicitaçao de dado do usuario.
            Console.WriteLine("Ola, nesse programa sera usado o metodo split para receber dados do usuario");
            Console.WriteLine("Digite em sequencia seu Nome, Idade e Altura.");

            //Tratamento dos dados.
            string[] vet = Console.ReadLine().Split(' ');
            nome = vet[0];
            idade = int.Parse(vet[1]);
            altura = Double.Parse(vet[2]);

            //Exibiçao de dados.
            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Sua idade é: " + idade);
            Console.WriteLine("Sua altura e´: " + altura);

            Console.ReadLine();
        }
    }
}

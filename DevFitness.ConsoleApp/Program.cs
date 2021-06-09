using System;
using System.Collections.Generic;
using System.Linq;

namespace DevFitness.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite sua altura");
            var altura = Console.ReadLine();
            Console.WriteLine("Digite seu peso");
            var peso = Console.ReadLine();

            var listaRefeicao = new List<Refeicao>();
            var opcao = "-1";
            while (!opcao.Equals("0"))
            {
                ExibirOpcoes();
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine($"Nome: {nome}, Altura: {altura}, Peso: {peso} \n");
                        break;
                    case "2":
                        Cadastrar(listaRefeicao);
                        break;
                    case "3":
                        ListarRefeicoes(listaRefeicao);
                        break;
                    default:
                        Console.WriteLine("Por favor, digite uma opção valida \n");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }

            //var bebida = new Bebida("Coca-cola", 150, false);
            //var comida = new Comida("Pizza", 500, 50.3m);
            //comida.ObterMensagem();
            //bebida.ObterMensagem();
        }

        public static void ExibirOpcoes()
        {
            Console.WriteLine("--- Seja bem-vindo(a) ao DevFitness ---" );
            Console.WriteLine("1 - Exibir detalhes de usuário");
            Console.WriteLine("2 - Cadastrar nova refeições");
            Console.WriteLine("3 - Listar todas refeições");
            Console.WriteLine("0 - Finalizar Aplicação");
        }

        public static void Cadastrar(List<Refeicao> refeicoes)
        {
            Console.WriteLine("Digite a descricao da refeicao.");
            var descricao = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de calorias.");
            var calorias = Console.ReadLine();

            if(int.TryParse(calorias, out int caloriasInt))
            {
                var refeicao = new Refeicao(descricao, caloriasInt);
                refeicoes.Add(refeicao);

                Console.WriteLine("Refeição adicionada com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de calorias inválido");
            }
        }

        public static void ListarRefeicoes(List<Refeicao> refeicoes)
        {
            foreach (var refeicao in refeicoes)
            {
                refeicao.ObterMensagem();
            }
        }
    }
}
//TESTE COM LINQ
//List<int> notas = new List<int> { 10, 1, 4, 8, 9, 2, 6, 2, 10 };
//var maioresQue3 = notas.Any(n => n > 3);
//var primeiraNota2 = notas.First(n => n == 2);
//var single = notas.Single(n => n == 9);
//var ordenada = notas.OrderBy(n => n);
//var pow2 = notas.Select(n => Math.Pow(n, 2));
//var max = notas.Max();
//var min = notas.Min();
//var sum = notas.Sum();
//var media = notas.Average();
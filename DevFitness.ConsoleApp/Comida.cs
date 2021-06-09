using System;
using System.Collections.Generic;
using System.Text;

namespace DevFitness.ConsoleApp
{
    public class Comida : Refeicao
    {
        public Comida(string descricao, int calorias, decimal preco) : base(descricao, calorias)
        {
            Preco = preco;
        }

        public decimal Preco { get; private set; }

        public override void ObterMensagem()
        {
            Console.WriteLine($"Descrição: {Descricao}, Calorias: {Calorias}, Preco: {Preco}");
        }
    }
}

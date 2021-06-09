using System;
using System.Collections.Generic;
using System.Text;

namespace DevFitness.ConsoleApp
{
    public class Bebida : Refeicao
    {
        public Bebida(string descricao, int calorias, bool contemLactose) : base(descricao, calorias)
        {
            ContemLactose = contemLactose;
        }
        public bool ContemLactose { get; private set; }
        public override void ObterMensagem()
        {
            Console.WriteLine($"Descrição: {Descricao}, Calorias: {Calorias}, e contem lactose: {ContemLactose}. ");
        }
    }
}

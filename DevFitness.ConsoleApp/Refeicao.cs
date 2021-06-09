using System;
using System.Collections.Generic;
using System.Text;

namespace DevFitness.ConsoleApp
{
    public class Refeicao
    {
        public Refeicao(string descricao, int calorias)
        {
            Descricao = descricao;
            Calorias = calorias;
        }

        // public = acesso aberto a todos
        // protected = acesso esta limitado a classe e suas derivadas
        // internal = acesso limitado ao assembly atual
        // private = acesso limitado a classe

        public string Descricao { get; private set; }
        public int Calorias { get; private set; }

        public virtual void ObterMensagem()
        {
            Console.WriteLine($"Descrição: {Descricao}, Calorias: {Calorias}");
        }
    }
}

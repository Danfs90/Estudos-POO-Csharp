using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    internal class Professor : Pessoa
    {
        public Professor(string nome, int idade) : base(nome, idade)
        {
        }

        public double Salario {get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou um professor com salario de {Salario}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, int idade) : base(nome, idade)
        {
        }

        public int Nota {get;set;}
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou um aluno nota {Nota}");
        }

    }
}

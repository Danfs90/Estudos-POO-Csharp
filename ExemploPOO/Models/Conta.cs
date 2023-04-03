using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo; //com protected somente a propria classe e as filhas podem acessar

        public abstract void Creditar(double valor); // como ele e abstrato nao posso criar um corpo para o metodo

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é {saldo}");
        }
    }
}

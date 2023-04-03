using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor) // aqui usamos o override para realizar o polimorfismo da classe Conta
        {
            base.saldo = valor;
        }
    }
}

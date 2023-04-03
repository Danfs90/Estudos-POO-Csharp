using System;
using ExemploPOO.Helper;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";
            FileHelper helper = new FileHelper();

            //helper.ListarArquivosDiretorios(caminho);

            helper.CriarDiretorio(Path.Combine(caminho,"Pasta Teste 3","Subpasta Teste 3"));

            //Computador comp = new Computador();
            //comp.ToString();
            //Retangulo r = new Retangulo();

            //r.DefinirMedidas(30, 30);

            //Console.WriteLine(r.GetArea());



            //Professor p1 = new Professor("Emanuel", 14);
            //p1.Apresentar();
            //p1.Salario = 1000;
            //p1.Documento = "teste";

            //Aluno p1 = new Aluno("Danilo",15);
            //p1.Apresentar();

            //Corrente c = new Corrente();
            //c.Creditar(100);
            //c.ExibirSaldo();
        }
    }
}
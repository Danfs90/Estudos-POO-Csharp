using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*",SearchOption.AllDirectories);
            
            foreach (var retorno in retornoCaminho)
            {
                Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*.txt", SearchOption.AllDirectories);

            foreach (var retorno in retornoArquivos)
            {
                Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio(string caminho)
        {
           var retorno = Directory.CreateDirectory(caminho);
            Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho)
        {
            Directory.Delete(caminho);
        }


        public void CriarArquivo(string caminho, string conteudo)
        {
            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)// Essa é a melhor maneira para se trabalhar com arquivos de dados de grande porte
        {
            using (var stream = File.CreateText(caminho)) 
            foreach (var linha in conteudo)
            {
                stream.WriteLine(linha);
            }
        }

        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

        public void AdicionarTextoStream(string caminho, string conteudo)
        {
            using (var stream =  File.AppendText(caminho))
            foreach(var linha in conteudo)
            {
                    stream.WriteLine(linha);
            }
        }

        public void LerArquivoTexto(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);
            foreach (var linha in conteudo)
            {
                Console.WriteLine(linha);
            }
        }
    
        public void LerArquivoStream(string caminho) //Maneira mais recomendada para ler arquivos grandes
        {
            string linha = string.Empty;

            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine())!= null) 
                {
                    Console.WriteLine(linha);
                }
            }
        }

        public void MoverArquivo(string caminho, string novoCaminho, bool sobscrever)
        {
            File.Move(caminho, novoCaminho, sobscrever);

        }

        public void CopiaArquivo(string caminho, string novoCaminho, bool sobscrever)
        {
            File.Copy(caminho, novoCaminho, sobscrever);
        }

        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}

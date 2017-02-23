using NewTISelvagem.Aplicacao;
using NewTISelvagem.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIDos
{
    class Program
    {
        static void Main(string[] args)
        {
            var appAluno = new AlunoAplicacao();

            var dados = appAluno.ListaTodos();

            foreach (var alunos in dados)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Código: {0} \nNome: {1} \nMãe: {2} \nData de Nascimento: {3}",
                    alunos.AlunoId, alunos.Nome, alunos.Mae, alunos.DataNascimento);
            }

            /*---------------------------------------------------------------------------------------------------------------------------*/

            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.Write("Digite o CÓDIGO a ser alterado/excluido: ");
            int codigo = Int32.Parse(Console.ReadLine());

            /*---------------------------------------------------------------------------------------------------------------------------*/

            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.Write("Digite o NOME a ser alterado/inserido: ");
            string nome = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.Write("Digite a MÃE a ser alterada/inserida: ");
            string mae = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.Write("Digite a DATA DE NASCIMENTO a ser alterada/inserida: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------------------------------");

            /*--ALTERAR------------------------------------------------------------------------------------------------------------------*/
            appAluno.Salvar(new Aluno { AlunoId = codigo, Nome = nome, Mae = mae, DataNascimento = data });
            /*---------------------------------------------------------------------------------------------------------------------------*/

            /*--INSERIR------------------------------------------------------------------------------------------------------------------*/
            //alunoSQL.Salvar(new Aluno { Nome = nome, Mae = mae, DataNascimento = data });
            /*---------------------------------------------------------------------------------------------------------------------------*/

            /*--DELETAR------------------------------------------------------------------------------------------------------------------*/
            //alunoSQL.Deletar(new Aluno { AlunoId = codigo });
            /*---------------------------------------------------------------------------------------------------------------------------*/

            var dados02 = appAluno.ListaTodos();

            foreach (var alunos in dados02)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Código: {0} \nNome: {1} \nMãe: {2} \nData de Nascimento: {3}",
                    alunos.AlunoId, alunos.Nome, alunos.Mae, alunos.DataNascimento);
            }
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
        }
    }
}

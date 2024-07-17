using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Teste_desenvolvimento.Repositorios
{
    public class PessoaRepositorio
    {
        public static class StringUtils
        {
            public static string RemoverCaracteres(string str)
            {
                if (str == null)
                {
                    return string.Empty;
                }
                return Regex.Replace(str, @"[^\w\s]", "");
            }
        }
        public void Inserir(Pessoa pessoa)
        {
            string cpfLimpo = StringUtils.RemoverCaracteres(pessoa.Cpf);
            using NpgsqlConnection conexao = (NpgsqlConnection) new DbConexao().GetConnection();
            conexao.Execute("INSERT INTO PESSOA (NOME, CPF, TELEFONE) VALUES(@nome, @cpf, @telefone);",
                new
                {
                    nome = pessoa.Nome,
                    cpf = cpfLimpo,
                    telefone = pessoa.Telefone

                });

        }
        public void Atualizar(Pessoa pessoa)
        {
            string cpfLimpo = StringUtils.RemoverCaracteres(pessoa.Cpf);
            using NpgsqlConnection conexao = (NpgsqlConnection)new DbConexao().GetConnection();
            conexao.Execute("UPDATE PESSOA SET NOME = @nome, CPF = @cpf, Telefone = @telefone WHERE ID = @id;",
                new
                {
                    nome = pessoa.Nome,
                    cpf = cpfLimpo,
                    telefone = pessoa.Telefone,
                    id = pessoa.Id

                });

        }
        public void Deletar(int id)
        {
            using NpgsqlConnection conexao = (NpgsqlConnection)new DbConexao().GetConnection();
            conexao.Execute("DELETE FROM PESSOA WHERE ID = @id;",
                new
                {
                    id
                });

        }

        public Pessoa BuscarPessoaPeloId(int id)
        {
            using NpgsqlConnection conexao = (NpgsqlConnection)new DbConexao().GetConnection();
            return conexao.QueryFirstOrDefault<Pessoa>(@"SELECT * FROM PESSOA WHERE ID = @id",
                new { id });
        }

        public IEnumerable<Pessoa> BuscarTodasPessoas()
        {
            using NpgsqlConnection conexao = (NpgsqlConnection)new DbConexao().GetConnection();
            return conexao.Query<Pessoa>(@"SELECT * FROM PESSOA");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_desenvolvimento
{
    public class Pessoa
    {
        private Pessoa() { }
        public Pessoa(int id, string nome, string cpf, int telefone)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public int Telefone { get; private set; }
    }
}

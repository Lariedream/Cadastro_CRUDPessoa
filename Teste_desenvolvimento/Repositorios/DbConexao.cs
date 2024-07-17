using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_desenvolvimento.Repositorios
{
    public class DbConexao : IDisposable
    {
        private readonly IDbConnection connection;

        public DbConexao()
        {
            connection = new NpgsqlConnection("Server=127.0.0.1 ; Port=54320; Database= cadastro_pessoa ; User Id= postgres ; Password= 1q2w3e4r5t ");
        }

        public IDbConnection GetConnection()
        {
            if(connection.State != ConnectionState.Open) 
                connection.Open();
            return connection;
        }
        public void Dispose() 
        {
            connection?.Dispose();

        }
    }
}

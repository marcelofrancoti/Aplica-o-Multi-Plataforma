﻿using System.Data;
using System.Data.SqlClient;

namespace Data.Dapper
{
    public  class Acesso
    {
        private IDbConnection _connection;
        public Acesso()
        {
            _connection = new SqlConnection(@"Data Source=MARCELODEV;Initial Catalog=TESTE_GTI;Integrated Security=True");
        }

        public IDbConnection dbConnectiondbConnection => _connection;
    }
}

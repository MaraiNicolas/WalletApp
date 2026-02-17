using System.Data;
using Microsoft.Data.SqlClient;
using WalletApp.Domain.Core.Abstracciones.SqlConnection;

namespace WalletApp.Infrastructure.Contexto.SqlConecction;

public class SqlConnectionFactory : ISqlConnectionFactory
{
    private readonly string _connectionString;

    public SqlConnectionFactory(string connectionString) => _connectionString = connectionString;

    public IDbConnection CreateConnection()
    {
        var connection = new SqlConnection(_connectionString);
        connection.Open();
        return connection;
    }
}
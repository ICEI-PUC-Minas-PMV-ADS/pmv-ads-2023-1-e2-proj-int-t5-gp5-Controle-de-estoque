using MySql.Data.MySqlClient;

namespace MeuProjeto.Repositories
{
    public static class MySQLConnectionFactory
    {
        public static MySqlConnection CreateConnection(string connectionString)
        {
            return new MySqlConnection(connectionString);
        }
    }
}

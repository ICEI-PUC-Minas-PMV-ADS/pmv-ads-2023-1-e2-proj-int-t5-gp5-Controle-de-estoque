using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MeuProjeto.Repositories
{
    public class FiliaisRepository
    {
        private readonly string connectionString;

        public FiliaisRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Filial> ListarFiliais()
        {
            List<Filial> filiais = new List<Filial>();
            using (MySqlConnection connection = MySQLConnectionFactory.CreateConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM filial";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Filial filial = new Filial();
                            filial.Id = reader.GetInt32(0);
                            filial.Nome = reader.GetString(1);
                            filial.Cidade = reader.GetString(2);
                            filial.Estado = reader.GetString(3);
                            filial.IdEmpresa = reader.GetInt32(4);
                            filiais.Add(filial);
                        }
                    }
                }
            }
            return filiais;
        }

        public void AdicionarFilial(Filial filial)
        {
            using (MySqlConnection connection = MySQLConnectionFactory.CreateConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO filial (Nome, Cidade, Estado, IdEmpresa) VALUES (@nome, @cidade, @estado, @idEmpresa)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", filial.Nome);
                    command.Parameters.AddWithValue("@cidade", filial.Cidade);
                    command.Parameters.AddWithValue("@estado", filial.Estado);
                    command.Parameters.AddWithValue("@idEmpresa", filial.IdEmpresa);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarFilial(Filial filial)
        {
            using (MySqlConnection connection = MySQLConnectionFactory.CreateConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE filial SET Nome=@nome, Cidade=@cidade, Estado=@estado, IdEmpresa=@idEmpresa WHERE Id=@id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", filial.Nome);
                    command.Parameters.AddWithValue("@cidade", filial.Cidade);
                    command.Parameters.AddWithValue("@estado", filial.Estado);
                    command.Parameters.AddWithValue("@idEmpresa", filial.IdEmpresa);
                    command.Parameters.AddWithValue("@id", filial.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ExcluirFilial(int id)
        {
            using (MySqlConnection connection = MySQLConnectionFactory.CreateConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM filial WHERE Id=@id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

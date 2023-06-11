using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTPLI
{
    public class FuncionariosDAO
    {
        string textoConexao
= "Server=(local)\\SQLEXPRESS;Database=ProvaProgramacao;Trusted_Connection=True;";
        public void Adicionar(string nome, string uf, string cidade, string endereco, string numero, string cpf)
        {
            using (SqlConnection connection = new SqlConnection(textoConexao))
            {
                string sql = "INSERT INTO Funcionarios (NOME, UF, CIDADE, ENDERECO, NUMERO, CPF) VALUES (@Nome, @UF, @CIDADE, @ENDERECO, @NUMERO, @CPF)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@UF", uf);
                    command.Parameters.AddWithValue("@CIDADE", cidade);
                    command.Parameters.AddWithValue("@ENDERECO", endereco);
                    command.Parameters.AddWithValue("@NUMERO", numero);
                    command.Parameters.AddWithValue("@CPF", cpf);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        // Função para atualizar uma cidade
        public void Atualizar(int id, string nome, string uf, string cidade, string endereco, string numero, string cpf)
        {
            using (SqlConnection connection = new SqlConnection(textoConexao))
            {
                string sql = "UPDATE Funcionarios SET Nome=@Nome, UF=@UF, CIDADE=@CIDADE, ENDERECO=@ENDERECO, NUMERO=@NUMERO, CPF=@CPF WHERE ID=@ID";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@UF", uf);
                    command.Parameters.AddWithValue("@CIDADE", cidade);
                    command.Parameters.AddWithValue("@ENDERECO", endereco);
                    command.Parameters.AddWithValue("@NUMERO", numero);
                    command.Parameters.AddWithValue("@CPF", cpf);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        // Função para excluir uma cidade
        public void Excluir(int id)
        {
            using (SqlConnection connection = new SqlConnection(textoConexao))
            {
                string sql = "DELETE FROM Funcionarios WHERE ID=@ID";
            using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        // Função para buscar uma cidade pelo id
        public DataTable Buscar(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(textoConexao))
            {
                string sql = "SELECT * FROM Funcionarios WHERE ID=@ID";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        // Função para listar todas as cidades (foi modificado para ficar no padrão)
        public DataTable ListarTodas()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(textoConexao))
            {
                string sql = "SELECT * FROM Funcionarios";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
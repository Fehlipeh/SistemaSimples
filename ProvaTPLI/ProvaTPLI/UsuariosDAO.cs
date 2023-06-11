using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTPLI
{
    internal class UsuariosDAO
    {
        string textoConexao = "Server=(local)\\SQLEXPRESS;Database=ProvaProgramacao;Trusted_Connection=True;";
 public Usuarios Login(string login, string senha)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(textoConexao))
            {
                string sql = "SELECT * FROM Usuarios WHERE Login=@pLogin AND Senha = @pSenha";
            using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@pLogin", login);
                    command.Parameters.AddWithValue("@pSenha", senha);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            //converte a pesquisa em um objeto
            Usuarios usuarios = null;
            //caso tenha encontrado apenas um registro com o usuário e senha
            if (dt.Rows.Count == 1)
            {
                usuarios = new Usuarios();
                //converte cada valor para seu tipo correto
                usuarios.ID = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
                usuarios.Nome = dt.Rows[0]["Nome"].ToString();
                usuarios.Login = dt.Rows[0]["Login"].ToString();
                usuarios.Senha = "A senha não é mostrada por segurança";
                usuarios.Nivel = Convert.ToInt32(dt.Rows[0]["Nivel"].ToString());
                usuarios.Ativo = Convert.ToBoolean(dt.Rows[0]["Ativo"].ToString());
            }
            //retorna o objeto
            return usuarios;
        }
    }
}
    

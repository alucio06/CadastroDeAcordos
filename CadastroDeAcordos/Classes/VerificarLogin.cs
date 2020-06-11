using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAcordos.Classes
{
    public class VerificarLogin
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";
        SqlDataReader lerDados;

        //verifica se email e senha estão corretos
        public bool usuarioEsenhaEstaoCorretos(string usuario, string senha)
        {
            bool validacao = false;

            cmd.Connection = conexao.conectar();
            cmd.CommandText = $"select * from Usuario where nomeLogin = '{usuario}' AND PWDCOMPARE('{senha}', senha) = 1";
            lerDados = cmd.ExecuteReader();
            if (lerDados.HasRows)
            {
                validacao = true;
            }
            conexao.desconectar();
            return validacao;
        }


    }
}

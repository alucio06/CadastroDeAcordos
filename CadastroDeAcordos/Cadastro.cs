using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CadastroDeAcordos
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";
        
        public Cadastro(string nome, string telefone)
        {
            //Comando SQL --SqlCommand
            cmd.CommandText = "insert into Teste (nome, telefone) values (@NOME, @TELEFONE)";

            //Parametros
            cmd.Parameters.AddWithValue("@NOME", nome);
            cmd.Parameters.AddWithValue("@TELEFONE", telefone);

            try
            {
                //Conectar com o banco de dados --Conexao
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar com o banco de dados
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com sucesso!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados"; 
            }
    
        }
    }
}

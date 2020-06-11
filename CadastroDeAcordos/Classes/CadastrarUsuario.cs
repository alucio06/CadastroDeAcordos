using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CadastroDeAcordos.Classes
{
    class CadastrarUsuario
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";
        SqlDataReader lerDados;
        DataTable tabela;

        public CadastrarUsuario(string email, string nomeUsuario, string senha)
        {
            //verifica se já existe email cadastrado
            if (usuarioJaCadastrado(email, nomeUsuario) == false)
            {
                //Comando SQL --SqlCommand
                cmd.CommandText = "insert into Usuario (email, nomeLogin, senha) values (@EMAIL, @NOMEUSUARIO, PWDENCRYPT(@SENHA))";

                //Parametros
                cmd.Parameters.AddWithValue("@EMAIL", email);
                cmd.Parameters.AddWithValue("@NOMEUSUARIO", nomeUsuario);
                cmd.Parameters.AddWithValue("@SENHA", senha);

                try
                {
                    //Conectar com o banco de dados --Conexao
                    cmd.Connection = conexao.conectar();
                    //executar comando
                    cmd.ExecuteNonQuery();
                    //desconectar com o banco de dados
                    conexao.desconectar();
                    //mostrar mensagem de erro ou sucesso
                    this.mensagem = "Usuário cadastrado com sucesso.";
                }
                catch (Exception e)
                {
                    this.mensagem = "Não foi possível cadastrar usuário" + e.Message;
                }
            }
        }

        //retorna se email ou usuario já estão cadastrados
        private bool usuarioJaCadastrado(string email, string nome)
        {
            bool validacao = false;

            if (emailJaCadastrado(email))
            {
                validacao = true;
                this.mensagem += "\n- O email digitado já possui cadastro.";
            }
            if (nomeJaCadastrado(nome))
            {
                validacao = true;
                this.mensagem += "\n- O nome de usuário digitado já está sendo utilizado. Por favor, utilize outro nome.";
            }
            return validacao;
        }


        //verifica se o nome de usuário digitado já está cadastrado
        private bool nomeJaCadastrado(string nomeUsuario)
        {
            bool validacao = false;

            cmd.Connection = conexao.conectar();
            cmd.CommandText = $"select * from Usuario where nomeLogin = '{nomeUsuario}'";
            lerDados = cmd.ExecuteReader();
            if (lerDados.HasRows)
            {
                validacao = true;
            }
            conexao.desconectar();

            return validacao;
        }


        //verifica se o email digitado já está cadastrado
        private bool emailJaCadastrado(string email)
        {
            bool validacao = false;

            cmd.Connection = conexao.conectar();
            cmd.CommandText = $"select * from Usuario where email = '{email}'";
            lerDados = cmd.ExecuteReader();
            if(lerDados.HasRows) 
            {
                validacao = true;
            }
            conexao.desconectar();

            return validacao;
        }

    }
}

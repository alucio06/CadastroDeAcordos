using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAcordos.Classes
{
    class Excluir
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public Excluir()
        {
        }

        //Edição para acordo que esteja concluído
        public Excluir(string numeroProcessual)
        {
            //Comando SQL --SqlCommand
            cmd.CommandText = $"delete from Acordoss where numeroProcessual = '{numeroProcessual}'";

            //Parametros
            cmd.Parameters.AddWithValue("@NUMEROPROCESSUAL", numeroProcessual);
            
            try
            {
                //Conectar com o banco de dados --Conexao
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar com o banco de dados
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Acordo excluído com sucesso.";
            }
            catch (Exception e)
            {
                this.mensagem = "Não foi possível excluir o acordo. \n" + e.Message; 
            }

        }

    }
}

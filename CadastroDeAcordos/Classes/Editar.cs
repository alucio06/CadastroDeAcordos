using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAcordos.Classes
{
    public class Editar
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem = "";

        public Editar()
        {
        }

        //Edição para acordo que esteja concluído
        public Editar(string numeroProcessualAtual, string numeroProcessualNovo, string tipoAcordo, string continente, string pais, string instituicao, DateTime dataPublicacao, DateTime dataInicio, DateTime dataFinal, string situacao, string interessado, string email, string telefone, string celular, string descricao, string status, DateTime dataUltStatus)
        {
            //Comando SQL --SqlCommand
            cmd.CommandText = $"update Acordoss set numeroProcessual = @NUMEROPROCESSUAL, tipoAcordo = @TIPOACORDO, continente = @CONTINENTE, pais = @PAIS, instituicao = @INSTITUICAO, dataPublicacao = @DATAPUBLICACAO, dataInicio = @DATAINICIO, dataFinal = @DATAFINAL, situacao = @SITUACAO, interessado = @INTERESSADO, email = @EMAIL, telefone = @TELEFONE, celular = @CELULAR, descricao = @DESCRICAO, status = @STATUS, dataUltStatus = @DATAULTSTATUS where numeroProcessual = '{numeroProcessualAtual}'";

            //Parametros
            cmd.Parameters.AddWithValue("@NUMEROPROCESSUAL", numeroProcessualNovo);
            cmd.Parameters.AddWithValue("@TIPOACORDO", tipoAcordo);
            cmd.Parameters.AddWithValue("@CONTINENTE", continente);
            cmd.Parameters.AddWithValue("@PAIS", pais);
            cmd.Parameters.AddWithValue("@INSTITUICAO", instituicao);
            cmd.Parameters.AddWithValue("@DATAPUBLICACAO", dataPublicacao);
            cmd.Parameters.AddWithValue("@DATAINICIO", dataInicio);
            cmd.Parameters.AddWithValue("@DATAFINAL", dataFinal);
            cmd.Parameters.AddWithValue("@SITUACAO", situacao);
            cmd.Parameters.AddWithValue("@INTERESSADO", interessado);
            cmd.Parameters.AddWithValue("@EMAIL", email);
            cmd.Parameters.AddWithValue("@TELEFONE", telefone);
            cmd.Parameters.AddWithValue("@CELULAR", celular);
            cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
            cmd.Parameters.AddWithValue("@STATUS", status);
            cmd.Parameters.AddWithValue("@DATAULTSTATUS", dataUltStatus);

            try
            {
                //Conectar com o banco de dados --Conexao
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar com o banco de dados
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Acordo editado com sucesso.";
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }

        }

        //Edição para acordo que não esteja concluído
        public Editar(string numeroProcessualAtual, string numeroProcessualNovo, string tipoAcordo, string continente, string pais, string instituicao, string situacao, string interessado, string email, string telefone, string celular, string descricao, string status, DateTime dataUltStatus)
        {
            //Comando SQL --SqlCommand
            cmd.CommandText = $"update Acordoss set numeroProcessual = @NUMEROPROCESSUAL, tipoAcordo = @TIPOACORDO, continente = @CONTINENTE, pais = @PAIS, instituicao = @INSTITUICAO, situacao = @SITUACAO, interessado = @INTERESSADO, email = @EMAIL, telefone = @TELEFONE, celular = @CELULAR, descricao = @DESCRICAO, status = @STATUS, dataUltStatus = @DATAULTSTATUS where numeroProcessual = '{numeroProcessualAtual}'";

            //Parametros
            cmd.Parameters.AddWithValue("@NUMEROPROCESSUAL", numeroProcessualNovo);
            cmd.Parameters.AddWithValue("@TIPOACORDO", tipoAcordo);
            cmd.Parameters.AddWithValue("@CONTINENTE", continente);
            cmd.Parameters.AddWithValue("@PAIS", pais);
            cmd.Parameters.AddWithValue("@INSTITUICAO", instituicao);
            cmd.Parameters.AddWithValue("@SITUACAO", situacao);
            cmd.Parameters.AddWithValue("@INTERESSADO", interessado);
            cmd.Parameters.AddWithValue("@EMAIL", email);
            cmd.Parameters.AddWithValue("@TELEFONE", telefone);
            cmd.Parameters.AddWithValue("@CELULAR", celular);
            cmd.Parameters.AddWithValue("@DESCRICAO", descricao);
            cmd.Parameters.AddWithValue("@STATUS", status);
            cmd.Parameters.AddWithValue("@DATAULTSTATUS", dataUltStatus);

            try
            {
                //Conectar com o banco de dados --Conexao
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar com o banco de dados
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Acordo editado com sucesso.";
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }

        }
    }
}

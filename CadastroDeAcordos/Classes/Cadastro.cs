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
        
        public Cadastro()
        {
        }

        //Cadastro para acordo concluído
        public Cadastro(string numeroProcessual, string tipoAcordo, string continente, string pais, string instituicao, DateTime dataPublicacao, DateTime dataInicio, DateTime dataFinal, string situacao, string interessado, string email, string telefone, string celular, string descricao, string status, DateTime dataUltStatus, DateTime dataCadastro)
        {
            //Comando SQL --SqlCommand
            cmd.CommandText = "insert into Acordos (numeroProcessual, tipoAcordo, continente, pais, instituicao, dataPublicacao, dataInicio, dataFinal, situacao, interessado, email, telefone, celular, descricao, status, dataUltStatus, dataCadastro ) values (@NUMEROPROCESSUAL, @TIPOACORDO, @CONTINENTE, @PAIS, @INSTITUICAO, @DATAPUBLICACAO, @DATAINICIO, @DATAFINAL, @SITUACAO, @INTERESSADO, @EMAIL, @TELEFONE, @CELULAR, @DESCRICAO, @STATUS, @DATAULTSTATUS, @DATACADASTRO)";

            //Parametros
            cmd.Parameters.AddWithValue("@NUMEROPROCESSUAL", numeroProcessual);
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
            cmd.Parameters.AddWithValue("@DATACADASTRO", dataCadastro);

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
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }
    
        }

        //Cadastro se o acordo não estiver concluído (sem data de publicacao, inicio e fim)
        public Cadastro(string numeroProcessual, string tipoAcordo, string continente, string pais, string instituicao, string situacao, string interessado, string email, string telefone, string celular, string descricao, string status, DateTime dataUltStatus, DateTime dataCadastro)
        {
            //Comando SQL --SqlCommand
            cmd.CommandText = "insert into Acordos (numeroProcessual, tipoAcordo, continente, pais, instituicao, situacao, interessado, email, telefone, celular, descricao, status, dataUltStatus, dataCadastro) values (@NUMEROPROCESSUAL, @TIPOACORDO, @CONTINENTE, @PAIS, @INSTITUICAO, @SITUACAO, @INTERESSADO, @EMAIL, @TELEFONE, @CELULAR, @DESCRICAO, @STATUS, @DATAULTSTATUS, @DATACADASTRO)";

            //Parametros
            cmd.Parameters.AddWithValue("@NUMEROPROCESSUAL", numeroProcessual);
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
            cmd.Parameters.AddWithValue("@DATACADASTRO", dataCadastro);

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
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }

        }
        
    }
}

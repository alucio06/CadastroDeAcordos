using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CadastroDeAcordos.Classes
{

    class RetornaDados
    {
        private Conexao conexao = new Conexao();

        SqlDataReader lerDados;
        DataTable tabela = new DataTable();
        SqlCommand comando = new SqlCommand();

        //retorna todos os dados(não filtrados) do banco
        public DataTable MostrarDados()
        {
            comando.Connection = conexao.conectar();
            comando.CommandText = "select numeroProcessual as 'Número Processual', tipoAcordo as 'Tipo de Acordo', continente as 'Continente', pais as 'País', instituicao as 'Instituição', dataPublicacao as 'Data de Publicação', dataInicio as 'Data de Início', dataFinal as 'Data Final', situacao as 'Situação', interessado as 'Interessado', email as 'Email', telefone as 'Telefone', celular as 'Celular', descricao as 'Descrição', [status] as 'Status', dataUltStatus as 'Data Último Status', dataCadastro as 'Data de Cadastro' From Acordoss";
            lerDados = comando.ExecuteReader();
            tabela.Load(lerDados);
            conexao.desconectar();
            return tabela;
        }

        //retorna dados filtrados por número processual
        public DataTable BuscarPorNumeroProcessual(string text)
        {
            comando.Connection = conexao.conectar();
            comando.CommandText = $"select numeroProcessual as 'Número Processual', tipoAcordo as 'Tipo de Acordo', continente as 'Continente', pais as 'País', instituicao as 'Instituição', dataPublicacao as 'Data de Publicação', dataInicio as 'Data de Início', dataFinal as 'Data Final', situacao as 'Situação', interessado as 'Interessado', email as 'Email', telefone as 'Telefone', celular as 'Celular', descricao as 'Descrição', [status] as 'Status', dataUltStatus as 'Data Último Status', dataCadastro as 'Data de Cadastro' From Acordoss where numeroProcessual = '{text}'";
            lerDados = comando.ExecuteReader();
            tabela.Load(lerDados);
            conexao.desconectar();
            return tabela;
        }

        //retorna dados filtrados por nome da instituição
        public DataTable BuscarPorInstituicao(string text)
        {
            comando.Connection = conexao.conectar();
            comando.CommandText = $"select numeroProcessual as 'Número Processual', tipoAcordo as 'Tipo de Acordo', continente as 'Continente', pais as 'País', instituicao as 'Instituição', dataPublicacao as 'Data de Publicação', dataInicio as 'Data de Início', dataFinal as 'Data Final', situacao as 'Situação', interessado as 'Interessado', email as 'Email', telefone as 'Telefone', celular as 'Celular', descricao as 'Descrição', [status] as 'Status', dataUltStatus as 'Data Último Status', dataCadastro as 'Data de Cadastro' From Acordoss where instituicao like '%{text}%' ";
            lerDados = comando.ExecuteReader();
            tabela.Load(lerDados);
            conexao.desconectar();
            return tabela;
        }

        //retorna dados filtrados por nome do interessado
        public DataTable BuscarPorInteressado(string text)
        {
            comando.Connection = conexao.conectar();
            comando.CommandText = $"select numeroProcessual as 'Número Processual', tipoAcordo as 'Tipo de Acordo', continente as 'Continente', pais as 'País', instituicao as 'Instituição', dataPublicacao as 'Data de Publicação', dataInicio as 'Data de Início', dataFinal as 'Data Final', situacao as 'Situação', interessado as 'Interessado', email as 'Email', telefone as 'Telefone', celular as 'Celular', descricao as 'Descrição', [status] as 'Status', dataUltStatus as 'Data Último Status', dataCadastro as 'Data de Cadastro' From Acordoss where interessado like '%{text}%' ";
            lerDados = comando.ExecuteReader();
            tabela.Load(lerDados);
            conexao.desconectar();
            return tabela;
        }
    }
}

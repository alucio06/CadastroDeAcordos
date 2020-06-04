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
            comando.CommandText = "select numeroProcessual as 'Número Processual', tipoAcordo as 'Tipo de Acordo', continente as 'Continente', pais as 'País', instituicao as 'Instituição', dataPublicacao as 'Data de Publicação', dataInicio as 'Data de Início', dataFinal as 'Data Final', situacao as 'Situação', interessado as 'Interessado', email as 'Email', telefone as 'Telefone', celular as 'Celular', descricao as 'Descrição', [status] as 'Status', dataUltStatus as 'Data Último Status', dataCadastro as 'Data de Cadastro' From Acordos order by dataCadastro desc";
            lerDados = comando.ExecuteReader();
            tabela.Load(lerDados);
            conexao.desconectar();
            return tabela;
        }

        //retorna dados filtrados por número processual
        public DataTable BuscarPorNumeroProcessual(string text, DataTable table)
        {
            var obj = (from m in table.AsEnumerable() where m.Field<string>("Número Processual") == text select m);
            DataTable dt = obj.CopyToDataTable();
            return dt;
        }

        //retorna dados filtrados por nome da instituição
        public DataTable BuscarPorInstituicao(string text, DataTable table)
        {
            var obj = (from m in table.AsEnumerable() where m.Field<string>("Instituição").ToLower().Contains(text.ToLower()) select m);
            DataTable dt = obj.CopyToDataTable();
            return dt;
        }

        //retorna dados filtrados por nome do interessado
        public DataTable BuscarPorInteressado(string text, DataTable table)
        {
            var obj = (from m in table.AsEnumerable() where m.Field<string>("Interessado").ToLower().Contains(text.ToLower()) select m);
            DataTable dt = obj.CopyToDataTable();
            return dt;
        }

        //retorna dados filtrados por tipo de acordo
        public DataTable FiltrarPorTipoDeAcordo(string text, DataTable table)
        {
            var obj = (from m in table.AsEnumerable() where m.Field<string>("Tipo de Acordo") == text select m);
            DataTable dt = obj.CopyToDataTable();
            return dt;
        }

        //retorna dados filtrados por situacao
        public DataTable FiltrarPorSituacao(string text, DataTable table)
        {
            var obj = (from m in table.AsEnumerable() where m.Field<string>("Situação") == text select m);
            DataTable dt = obj.CopyToDataTable();
            return dt;
        }

        //retorna dados filtrados por continente
        public DataTable FiltrarPorContinente(string text, DataTable table)
        {
            var obj = (from m in table.AsEnumerable() where m.Field<string>("Continente") == text select m);
            DataTable dt = obj.CopyToDataTable();
            return dt;
        }

        //retorna dados filtrados por país
        public DataTable FiltrarPorPais(string text, DataTable table)
        {
            var obj = (from m in table.AsEnumerable() where m.Field<string>("País") == text select m);
            DataTable dt = obj.CopyToDataTable();
            return dt;
        }

        //retorna somente os acordos vigentes
        public DataTable RetornaAcordosVigentes()
        {
            comando.Connection = conexao.conectar();
            comando.CommandText = "select numeroProcessual as 'Número Processual', tipoAcordo as 'Tipo de Acordo', continente as 'Continente', pais as 'País', instituicao as 'Instituição', dataPublicacao as 'Data de Publicação', dataInicio as 'Data de Início', dataFinal as 'Data Final', interessado as 'Interessado', descricao as 'Descrição' from Acordos where situacao = '[CONCLUÍDO] ARQUIVADO' AND dataFinal >= convert(date, GETDATE(), 101)";
            lerDados = comando.ExecuteReader();
            tabela.Load(lerDados);
            conexao.desconectar();
            return tabela;
        }

        //retorna todos os tipos de situações possíveis cadastradas no banco de dados
        public IEnumerable<string> SituacoesPossiveis(string text)
        {
            comando.Connection = conexao.conectar();
            comando.CommandText = "SELECT DISTINCT situacao from Acordos";
            lerDados = comando.ExecuteReader();
            tabela.Load(lerDados);
            conexao.desconectar();

            List<string> lista = new List<string>();

            if(text == "visualizar") { lista.Add("Todos"); }

            foreach (DataRow linha in tabela.Rows)
            {
                lista.Add(linha[0].ToString());
            }

            return lista;
        }

        //retorna todos os tipos de acordos cadastrados no banco de dados
        public IEnumerable<string> tiposDeAcordo(string text)
        {
            comando.Connection = conexao.conectar();
            comando.CommandText = "select distinct tipoAcordo FROM Acordos";
            lerDados = comando.ExecuteReader();
            tabela.Load(lerDados);
            conexao.desconectar();

            List<string> lista = new List<string>();

            if (text == "visualizar") { lista.Add("Todos"); }

            foreach (DataRow linha in tabela.Rows)
            {
                lista.Add(linha[0].ToString());
            }

            return lista;
        }

    }
}

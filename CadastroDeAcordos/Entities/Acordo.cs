using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroDeAcordos.Entities.Enums;

namespace CadastroDeAcordos.Entities
{
    class Acordo
    {
        //atributos
        public int Id { get; set; }
        public string Numero { get; set; }
        public TipoDeAcordo TipoDeAcordo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataDePublicacao { get; set; }
        public DateTime DataDeInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public Instituicao Instituicao { get; set; }
        public Situacao Situacao { get; set; }
        public Interessado Interessado { get; set; }
        public List<Status> ListaDeStatus = new List<Status>();

        //construtor
        public Acordo()
        {
        }

        public Acordo(int id, string numero, TipoDeAcordo tipoDeAcordo, DateTime dataCadastro, Instituicao instituicao, Situacao situacao, Interessado interessado)
        {
            Id = id;
            Numero = numero;
            TipoDeAcordo = tipoDeAcordo;
            DataCadastro = dataCadastro;
            Instituicao = instituicao;
            Situacao = situacao;
            Interessado = interessado;
        }

        //métodos
        public void AtualizarStatus(string status)
        {
            ListaDeStatus.Add(new Status(ListaDeStatus.Count + 1, status, DateTime.Now));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAcordos.Entities
{
    class Instituicao
    {
        //atributos
        public string Nome { get; set; }
        public string Continente { get; set; }
        public string Pais { get; set; }

        //construtor
        public Instituicao()
        {
        }

        public Instituicao(string nome, string continente, string pais)
        {
            Nome = nome;
            Continente = continente;
            Pais = pais;
        }
    }
}

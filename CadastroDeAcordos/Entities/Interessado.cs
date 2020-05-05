using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAcordos.Entities
{
    class Interessado
    {
        //atributos
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Instituto { get; set; }

        //construtor
        public Interessado(string nome, string email, string telefone, string instituto)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Instituto = instituto;
        }
    }
}

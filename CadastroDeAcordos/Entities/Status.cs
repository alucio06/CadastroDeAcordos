using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAcordos.Entities
{
    class Status
    {
        //atributos
        public int Id { get; set; }
        public string UltimoStatus { get; set; }
        public DateTime DataUltimoStatus { get; set; }

        //construtor
        public Status(int id, string ultimoStatus, DateTime dataUltimoStatus)
        {
            Id = id;
            UltimoStatus = ultimoStatus;
            DataUltimoStatus = dataUltimoStatus;
        }
    }
}

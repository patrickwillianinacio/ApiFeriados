using ApiFeriados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFeriados.Models
{
    public class Cidade
    {
        public int CidadeId { get; set; }
        public string cidade_descricao { get; set; }
        public string cidade_abreviada { get; set; }
        public List<Ano> Anos { get; set; } = new List<Ano>();
    }
}

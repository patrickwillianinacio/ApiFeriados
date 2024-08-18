using ApiFeriados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFeriados.Models
{
    public class Ano
    {
        public int NumeroAno { get; set; }
        public List<Feriado> Feriados { get; set; } = new List<Feriado>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFeriados.Models
{
    public class Feriado
    {
        public DateTime Data { get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; } // Pode ser "Federal", "Estadual", "Municipal"
    }
}
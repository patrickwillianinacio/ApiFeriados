using System.Collections.Generic;


namespace ApiFeriados.Models
{
    public class Estado
    {
        public int EstadoId { get; set; }
        public string estado_descricao { get; set; }
        public string estado_sigla { get; set; }
        public List<Ano> Anos { get; set; } = new List<Ano>();
    }
}
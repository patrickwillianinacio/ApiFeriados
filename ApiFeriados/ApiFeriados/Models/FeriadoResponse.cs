using System;

namespace ApiFeriados.Models
{
    public class FeriadoResponse
    {
        public DateTime Date { get; set; }
        public string LocalName { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string Type { get; set; }
    }
}

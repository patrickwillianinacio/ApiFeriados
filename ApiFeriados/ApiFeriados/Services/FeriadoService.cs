using ApiFeriados.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;

namespace ApiFeriados.Services
{
    public class FeriadoService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<FeriadoService> _logger;

        public FeriadoService(HttpClient httpClient, ILogger<FeriadoService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<List<Feriado>> ObterFeriadosNacionais(int year)
        {
            var feriados = new List<Feriado>();
            var url = $"https://date.nager.at/Api/v2/PublicHoliday/{year}/BR";
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var dados = JsonConvert.DeserializeObject<List<FeriadoResponse>>(content);

                foreach (var holiday in dados)
                {
                    var feriado = new Feriado
                    {
                        Data = holiday.Date,
                        Titulo = holiday.LocalName,
                        Tipo = holiday.Type
                    };
                    feriados.Add(feriado);
                }
            }
            return feriados;
        }

        public async Task<List<Feriado>> ObterFeriadosEstaduais(string stateCode, int year)
        {
            // Implemente a lógica para obter feriados estaduais, por exemplo, uma URL específica para cada estado
            var feriados = new List<Feriado>();
            var url = $"https://date.nager.at/api/v2/PublicHolidays/{year}/BR"; // BR é o código do país para Brasil
            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var dados = JsonConvert.DeserializeObject<List<FeriadoResponse>>(content);

                foreach (var holiday in dados)
                {
                    var feriado = new Feriado
                    {
                        Data = holiday.Date,
                        Titulo = holiday.LocalName,
                        Tipo = "Estadual"
                    };
                    feriados.Add(feriado);
                }
            }
            return feriados;
        }

        public async Task<List<Feriado>> ObterFeriadosMunicipais(string cityCode, int year)
        {
            var feriados = new List<Feriado>();
            var url = $"https://date.nager.at/Api/v2/PublicHoliday/{year}/BR";
            var response = await _httpClient.GetAsync(url);


            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var dados = JsonConvert.DeserializeObject<List<FeriadoResponse>>(content);

                foreach (var holiday in dados)
                {
                    var feriado = new Feriado
                    {
                        Data = holiday.Date,
                        Titulo = holiday.LocalName,
                        Tipo = holiday.Type
                    };
                    feriados.Add(feriado);
                }
            }

            return feriados;
        }
    }
}
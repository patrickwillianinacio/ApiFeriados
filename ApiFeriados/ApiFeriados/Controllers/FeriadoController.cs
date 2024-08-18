using ApiFeriados.Models;
using ApiFeriados.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiFeriados.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeriadosController : ControllerBase
    {
        private readonly FeriadoService _feriadoService;

        public FeriadosController(FeriadoService feriadoService)
        {
            _feriadoService = feriadoService;
        }

        [HttpGet("nacionais/{year}")]
        public async Task<ActionResult<List<Feriado>>> ObterFeriadosNacionais(int year)
        {
            var feriados = await _feriadoService.ObterFeriadosNacionais(year);
            return Ok(feriados);
        }

        [HttpGet("estaduais/{stateCode}/{year}")]
        public async Task<ActionResult<List<Feriado>>> ObterFeriadosEstaduais(string stateCode, int year)
        {
            var feriados = await _feriadoService.ObterFeriadosEstaduais(stateCode, year);
            return Ok(feriados);
        }

        [HttpGet("municipais/{cityCode}/{year}")]
        public async Task<ActionResult<List<Feriado>>> ObterFeriadosMunicipais(string cityCode, int year)
        {
            var feriados = await _feriadoService.ObterFeriadosMunicipais(cityCode, year);
            return Ok(feriados);
        }
    }
}

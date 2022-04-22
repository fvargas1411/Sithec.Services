using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sithec.Humano.Comandos.Comandos;
using Sithec.Humano.Consultas.Interfaces;
using Sithec.Humano.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sithec.Humano.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HumanoController : ControllerBase
    {
        private readonly IHumano _Humano;
        private readonly IMediator _mediator;

        public HumanoController(IHumano humanoquery, IMediator mediator) 
        {
            this._Humano = humanoquery;
            _mediator = mediator;
        }

        [Route("obtieneHumanos")]
        [HttpGet]
        public async Task<IActionResult> obtieneHumanos()
        {            
            var result = await _Humano.obtieneHumanos();

            return Ok(result);
        }

        [Route("obtieneHumanosDb")]
        [HttpGet]
        public async Task<IEnumerable<HumanoDto>> obtieneHumanosDb()
        {
            var result = await _Humano.obtieneHumanosDb();

            return result;
        }

        [Route("obtieneHumanoDb")]
        [HttpGet]
        public async Task<HumanoDto> obtieneHumanoDb(int Id)
        {
            var result = await _Humano.obtieneHumanoDB(Id);

            return result;
        }

        [Route("creaHumano")]        
        [HttpPost]
        public async Task<IActionResult> creaHumano([FromBody] CrearHumanoCommand cmd)
        {
            await _mediator.Publish(cmd);
            return Ok();
        }

        [Route("actualizaHumano")]
        [HttpPost]
        public async Task<IActionResult> actualizaHumano([FromBody] ActualizarHumanoCommand cmd)
        {
            await _mediator.Publish(cmd);
            return Ok();
        }

    }
}

using API_A2W.Domain.Interfaces.Services.Carro;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace API_A2W.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        protected readonly ICarroService _service;

        public CarroController(ICarroService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<ActionResult> GetAllCarros()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.getAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }


    }
}

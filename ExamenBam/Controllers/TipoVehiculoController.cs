using BAM.APLICATION.Services;
using BAM.DOMAIN.Interfaces.Repository;
using BAM.DOMAIN.Models;
using BAM.INFRASTRUCTURE.DATA.Contexts;
using BAM.INFRASTRUCTURE.DATA.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamenBam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoVehiculoController : ControllerBase
    {
        TipoVehiculoService tipoVehiculoService()
        {
            BAMContext context = new BAMContext();
            TipoVehiculoRepository bamRepository = new(context);
            TipoVehiculoService tipoVehiculoService = new(bamRepository);


            return tipoVehiculoService;

        }
        // GET: api/<TipoVehiculoController>
        [HttpGet]
        public ActionResult<List<TipoVehiculo>> Get()
        {
            var servicio = tipoVehiculoService();
            return Ok(servicio.Get());
        }

        // GET api/<TipoVehiculoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TipoVehiculoController>
        [HttpPost]
        public ActionResult Post([FromBody] TipoVehiculo pTipoVehiculo)
        {
            var servicio = tipoVehiculoService();
            servicio.Add(pTipoVehiculo);
            return Ok("Se agrego el tipo de vehiculo correctamente");

        }

        // PUT api/<TipoVehiculoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TipoVehiculoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

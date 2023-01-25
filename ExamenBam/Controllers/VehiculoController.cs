using Microsoft.AspNetCore.Mvc;

using BAM.APLICATION.Services;
using BAM.INFRASTRUCTURE.DATA.Contexts;
using BAM.INFRASTRUCTURE.DATA.Repository;
using BAM.DOMAIN.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamenBam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        // GET: api/<VehiculoController>

        VehiculoService vehiculoService()
        {
            BAMContext context = new BAMContext();
            BamRepository bamRepository = new(context);
            VehiculoService vehiculoService = new(bamRepository);


            return vehiculoService;

        }

        [HttpGet]
        public ActionResult<List<Vehiculo>> Get()
        {
            //BAMContext bAMContext = new BAMContext();
           // bAMContext.Database.EnsureDeleted();
            //bAMContext.Database.EnsureCreated();
            var servicio = vehiculoService();
            return Ok(servicio.Get());
        }

        // GET api/<VehiculoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VehiculoController>
        [HttpPost]
        public ActionResult Post([FromBody] Vehiculo pVehiculo)
        {
            var servicio = vehiculoService();
            servicio.Add(pVehiculo);

            return Ok("Se agrego satisfactoriamente");
        }

        // PUT api/<VehiculoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VehiculoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

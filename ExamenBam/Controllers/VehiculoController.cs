using Microsoft.AspNetCore.Mvc;

using BAM.APLICATION.Services;
using BAM.INFRASTRUCTURE.DATA.Contexts;
using BAM.INFRASTRUCTURE.DATA.Repository;
using BAM.DOMAIN.Models;
using Microsoft.EntityFrameworkCore;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamenBam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        // GET: api/<VehiculoController>


        private readonly VehiculoService _service;

       /* VehiculoService vehiculoService()
        {
            BAMContext context = new BAMContext();
            BamRepository bamRepository = new(context);
            VehiculoService vehiculoService = new(bamRepository);


            return vehiculoService;

        }*/
        public VehiculoController(VehiculoService vehiculoService)
        {
            _service = vehiculoService;
        }



        [HttpGet]
        public ActionResult<List<Vehiculo>> Get()
        {
            BAMContext bAMContext = new BAMContext();
            //bAMContext.Database.EnsureDeleted();
            bAMContext.Database.EnsureCreated();
            //var servicio =  vehiculoService();
            //BAMContext context = new BAMContext();
            //context.Database.GetPendingMigrations();
            return Ok(_service.Get());
        }

        // GET api/<VehiculoController>/5
        [HttpGet("{id}")]
        public ActionResult<Vehiculo> Get(Guid id)
        {
            return _service.GetById(id);
        } 

        // POST api/<VehiculoController>
        [HttpPost]
        public ActionResult Post([FromBody] Vehiculo pVehiculo)
        {
            //var servicio = vehiculoService();
            _service.Add(pVehiculo);

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

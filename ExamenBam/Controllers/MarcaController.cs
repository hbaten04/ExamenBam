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


    public class MarcaController : ControllerBase
    {

        private readonly MarcaService _service;
        public MarcaController(MarcaService service)
        {
            _service = service;
        }

        /*MarcaService marcaService()
        {
            BAMContext context = new BAMContext();
            MarcaRepository bamRepository = new(context);
            MarcaService marcaService = new(bamRepository);


            return marcaService;

        }*/

        // GET: api/<MarcaController>
        [HttpGet]
        public ActionResult<List<Marca>> Get()
        {
            //var servicio = marcaService();
            return Ok(_service.Get());
        }

        // GET api/<MarcaController>/5
       /*[HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST api/<MarcaController>
        [HttpPost]
        public ActionResult Post([FromBody] Marca pMarca)
        {
            // var servicio = marcaService();
            _service.Add(pMarca);
            return Ok("Se agrego la marca de forma exitosa");
        }

        // PUT api/<MarcaController>/5
      /*  [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MarcaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}

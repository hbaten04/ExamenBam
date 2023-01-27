using BAM.APLICATION.Services;
using BAM.DOMAIN.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamenBam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotizacionQueryController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly CotizacionService _service;
        public CotizacionQueryController(IConfiguration configuration, CotizacionService service)
        {
            _configuration = configuration;
            _service = service;
        }
        // GET: api/<CotizacionQueryController>
        [HttpGet("{id}/{enganche}")]
        public IActionResult Get(Guid id, decimal enganche, int plazo)
        {
            string sql = $"SELECT dbo.FNC_CALCULO_PAGO(0.12,{plazo}, (PrecioVehiculo-{enganche})) PAGO, VehiculoId " +
                        "FROM TBLVEHICULO " +
                        "WHERE VehiculoId ='" + id + "'";

            using var connection = new SqlConnection(_configuration.GetConnectionString("Connection"));

            var cotizacion = connection.Query<dynamic>(sql).ToList();
            //cotizacion[0].PAGO
            return Ok(cotizacion);
        }

        // GET api/<CotizacionQueryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CotizacionQueryController>
        [HttpPost]
        public ActionResult Post([FromBody] Cotizacion cotizacion)
        {
            string sql = $"SELECT {cotizacion.Plazo} PLAZO, dbo.FNC_CALCULO_PAGO(0.12,{cotizacion.Plazo}, (PrecioVehiculo-{cotizacion.Enganche})) PAGO, VehiculoId, '{cotizacion.EmailCliente}' as EMAILCLIENTE " +
                        "FROM TBLVEHICULO " +
                        "WHERE VehiculoId ='" + cotizacion.VehiculoId + "'";

            using var connection = new SqlConnection(_configuration.GetConnectionString("Connection"));

            var vCotizacion = connection.Query<dynamic>(sql).ToList();

            cotizacion.CuotaPago = Convert.ToDecimal(vCotizacion[0].PAGO);

            _service.Add(cotizacion);
            return Ok(vCotizacion);
        }

        // PUT api/<CotizacionQueryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CotizacionQueryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

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
        public CotizacionQueryController(IConfiguration configuration)
        {
            _configuration = configuration;
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
        public void Post([FromBody] string value)
        {
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

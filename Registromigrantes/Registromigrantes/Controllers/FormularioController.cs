using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Registromigrantes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormularioController : ControllerBase
    {
        [HttpGet("ConexionServidor")]
        public async Task<string> ConexionServidor()
        {
            return "Conexión exitosa";
        }
    }
}

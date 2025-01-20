using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Registromigrantes.Data;

namespace Registromigrantes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormularioController : ControllerBase
    {

        private readonly AplicationDbContext _context;
        
        public FormularioController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("ConexionServidor")]
        public async Task<ActionResult<string>> ConexionServidor()
        {
            return "Conexión exitosa con el servidor";
        }

        [HttpGet("ConexionFormulario")]
        public async Task<ActionResult<string>> ConexionFormulario()
        {
            try
            {
                var respuesta = await _context.Formulario.ToListAsync();
                return "Conexión exitosa con la base de datos";
            }
            catch (Exception ex)
            {
                return $"Error de conexión: {ex.Message}";
            }
        }
    }
}

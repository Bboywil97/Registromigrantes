using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registromigrantes.Server.Data;

namespace Registromigrantes.shared
{
    public class Formulario
    {
        public int Id { get; set; } // Asegúrate de que la propiedad se llame 'Id' con mayúscula
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string OcupacionPrevia { get; set; }
        public string OcupacionDeseada { get; set; }
        public string LugarOrigen { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaCreacion { get; set; }
    }

    public class FormularioService
    {
        public async Task<string> CrearFormulario(Formulario formulario)
        {
            try
            {
                using (var context = new AplicationDbContext())
                {
                    context.Formulario.Add(formulario);
                    await context.SaveChangesAsync();
                    return "Formulario creado exitosamente";
                }
            }
            catch (Exception ex)
            {
                return $"Error al crear el formulario: {ex.Message}";
            }
        }
        public async Task<List<Formulario>> ObtenerFormularios()
        {
            try
            {
                using (var context = new AplicationDbContext())
                {
                    return await context.Formulario.ToListAsync();
                }
            }
            catch (Exception ex)
            {
                return new List<Formulario>();
            }
        }

    }
}

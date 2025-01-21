using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}

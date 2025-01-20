using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registromigrantes.shared
{
    internal class Login
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; } 

        public DateTime FechaCreacion { get; set; }

        public DateTime UltimoAcceso { get; set; }
    }
}

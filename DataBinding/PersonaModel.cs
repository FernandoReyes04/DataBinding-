using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding
{
    public class PersonaModel
    {
        public int id_persona { get; set; } // ID único para la persona

        public string nombre { get; set; } // Nombre de la persona

        public string apellido { get; set; } // Apellido de la persona

        public string sexo { get; set; } // Sexo: "h" (hombre) o "m" (mujer)

        public DateTime fh_nac { get; set; } // Fecha de nacimiento

        public int id_rol { get; set; } // ID del rol asociado
    }
}

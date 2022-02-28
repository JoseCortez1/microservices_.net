using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaServicios.API.Author.Modelo
{
    public class AutorLibro
    {
        public int AutorLibroId { get; set; }
        public string  Nombre { get; set;}
        public string Apellido { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public ICollection<GradoAcademico> ListaGradosAcademicos { get; set; }

        public string AutorLibroGuid { get; set; }

    }
}

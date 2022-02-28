using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaServicios.API.Author.Modelo
{
    public class GradoAcademico
    {
        public int GradoAcademicoId { get; set; }
        public string Nombre { get; set; }

        public string CentroAcademico { get; set; }

        public DateTime? FechaGRado { get; set; }

        public int AutorLibroId { get; set; }

        public AutorLibro AutorLibro { get; set; }

        public string GradoAcademicoGuid { get; set; }

    }
}

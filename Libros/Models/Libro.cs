using System;
using System.Collections.Generic;

#nullable disable

namespace Libros.Models
{
    public partial class Libro
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public int idioma_id { get; set; }
        public int? Año { get; set; }
        public int? NumPaginas { get; set; }
        public int AutorId { get; set; }

        public virtual Autor Autor { get; set; }
        public virtual Idioma Idioma { get; set; }
    }
}

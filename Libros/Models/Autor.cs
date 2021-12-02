using System;
using System.Collections.Generic;

#nullable disable

namespace Libros.Models
{
    public partial class Autor
    {
        public Autor()
        {
            Libros = new HashSet<Libro>();
        }

        public int IdAutor { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int PaisId { get; set; }
        public int GeneroId { get; set; }

        public virtual Genero Genero { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual ICollection<Libro> Libros { get; set; }
    }
}

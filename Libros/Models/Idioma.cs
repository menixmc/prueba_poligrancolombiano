using System;
using System.Collections.Generic;

#nullable disable

namespace Libros.Models
{
    public partial class Idioma
    {
        public Idioma()
        {
            Libros = new HashSet<Libro>();
        }

        public int Id_Idioma { get; set; }
        public string Idioma1 { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}

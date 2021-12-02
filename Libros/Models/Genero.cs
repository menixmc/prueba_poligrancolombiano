using System;
using System.Collections.Generic;

#nullable disable

namespace Libros.Models
{
    public partial class Genero
    {
        public Genero()
        {
            Autors = new HashSet<Autor>();
        }

        public int IdGenero { get; set; }
        public string Genero1 { get; set; }

        public virtual ICollection<Autor> Autors { get; set; }
    }
}

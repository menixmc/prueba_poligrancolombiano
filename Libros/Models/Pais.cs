using System;
using System.Collections.Generic;

#nullable disable

namespace Libros.Models
{
    public partial class Pais
    {
        public Pais()
        {
            Autors = new HashSet<Autor>();
        }

        public int IdPais { get; set; }
        public string NombrePais { get; set; }

        public virtual ICollection<Autor> Autors { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class libro
    {
        public int id_libro { get; set; }
        public string titulo { get; set; }
        public string editorial { get; set; }
        public int idioma_id { get; set; }
        public Nullable<int> año { get; set; }
        public Nullable<int> num_paginas { get; set; }
        public int autor_id { get; set; }
    
        public virtual autor autor { get; set; }
        public virtual idioma idioma { get; set; }
    }
}
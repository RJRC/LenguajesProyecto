//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADL
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsuarioCocina
    {
        public int UsuarioCocinaID { get; set; }
        public string CorreoElectronico { get; set; }
    
        public virtual Party Party { get; set; }
    }
}
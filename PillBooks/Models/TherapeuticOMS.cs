//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PillBooks.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TherapeuticOMS
    {
        public TherapeuticOMS()
        {
            this.PillBookATCOMS = new HashSet<PillBookATCOMS>();
        }
    
        public int TherapeuticOMSId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string TherapeuticKey { get; set; }
        public string Description { get; set; }
        public string SpanishDescription { get; set; }
        public bool Active { get; set; }
        public Nullable<int> Level { get; set; }
    
        public virtual ICollection<PillBookATCOMS> PillBookATCOMS { get; set; }
    }
}
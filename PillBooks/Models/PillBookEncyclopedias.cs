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
    
    public partial class PillBookEncyclopedias
    {
        public int PillBookId { get; set; }
        public int EditionId { get; set; }
        public int AttributeId { get; set; }
        public int AttributeGroupId { get; set; }
        public int EncyclopediaId { get; set; }
    
        public virtual Encyclopedias Encyclopedias { get; set; }
        public virtual EditionPillBookAttributes EditionPillBookAttributes { get; set; }
    }
}
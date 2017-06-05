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
    
    public partial class Products
    {
        public Products()
        {
            this.ProductSubstances = new HashSet<ProductSubstances>();
            this.ProductPharmaForms = new HashSet<ProductPharmaForms>();
        }
    
        public int ProductId { get; set; }
        public int CountryId { get; set; }
        public int LaboratoryId { get; set; }
        public byte AlphabetId { get; set; }
        public byte ProductTypeId { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string SanitaryRegistry { get; set; }
        public bool Active { get; set; }
    
        public virtual Countries Countries { get; set; }
        public virtual ICollection<ProductSubstances> ProductSubstances { get; set; }
        public virtual ICollection<ProductPharmaForms> ProductPharmaForms { get; set; }
    }
}

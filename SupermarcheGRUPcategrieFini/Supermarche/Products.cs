//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Supermarche
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public Products()
        {
            this.Price = 0;
            this.Quantity = 0;
            this.Status = "Avaible";
            this.Sections = new HashSet<Sections>();
            this.Checkouts = new HashSet<Checkout>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<Sections> Sections { get; set; }
        public virtual ICollection<Checkout> Checkouts { get; set; }
    }
}

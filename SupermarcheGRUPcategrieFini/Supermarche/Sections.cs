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
    
    public partial class Sections
    {
        public Sections()
        {
            this.Employees = new HashSet<Employees>();
            this.Products = new HashSet<Products>();
        }
    
        public int Id { get; set; }
        public string Categorie { get; set; }
    
        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
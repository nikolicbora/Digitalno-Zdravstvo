//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalnaApoteka.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Apoteka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Apoteka()
        {
            this.Apotekars = new HashSet<Apotekar>();
        }
    
        public int idApoteka { get; set; }
        public decimal lat { get; set; }
        public decimal lon { get; set; }
        public string naziv { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Apotekar> Apotekars { get; set; }
    }
}

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
    
    public partial class Recept
    {
        public int idRecept { get; set; }
        public System.DateTime DatumIzdavanja { get; set; }
        public Nullable<int> DoziranjePrepodne { get; set; }
        public Nullable<int> DoziranjePopodne { get; set; }
        public Nullable<int> DoziranjeUvece { get; set; }
        public string DoziranjeSirup { get; set; }
        public int idLek { get; set; }
        public string idPacijent { get; set; }
        public string idLekar { get; set; }
        public string Obradio { get; set; }
    
        public virtual Apotekar Apotekar { get; set; }
        public virtual Lek Lek { get; set; }
        public virtual Lekar Lekar { get; set; }
        public virtual Pacijent Pacijent { get; set; }
    }
}

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
    using System.ComponentModel.DataAnnotations;

    public partial class Lekar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lekar()
        {
            this.Recepts = new HashSet<Recept>();
            this.Termins = new HashSet<Termin>();
        }

        [Required(ErrorMessage = "Morate uneti username")]
        [Display(Name = "Username:")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Morate uneti password")]
        [Display(Name = "Password:")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Morate uneti datum rodjenja")]
        [Display(Name = "Datum Rodjenja")]
        [DataType(DataType.Date)]
        public System.DateTime DatumRodjenja { get; set; }
        [Required(ErrorMessage = "Morate uneti mail")]
        [Display(Name = "Mail")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Morate uneti telefon")]
        [Display(Name = "Telefon")]
        [DataType(DataType.PhoneNumber)]
        public string Telefon { get; set; }
        [Required(ErrorMessage = "Ime")]
        [Display(Name = "Ime")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Prezime")]
        [Display(Name = "Prezime")]
        public string Prezime { get; set; }
        [Required(ErrorMessage = "Pol")]
        [Display(Name = "Pol")]
        public string Pol { get; set; }
        [Required(ErrorMessage = "Sprat")]
        [Display(Name = "Sprat")]
        [RegularExpression(@"[0-9]{1,2}", ErrorMessage = "Soba je dvocifren broj")]
        public int Sprat { get; set; }
        [Required(ErrorMessage = "Prostorija")]
        [Display(Name = "Prostorija")]
        [RegularExpression(@"[0-9]{1,3}", ErrorMessage = "Prostorija je trocifren broj")]
        public string Prostorija { get; set; }
        [Required(ErrorMessage = "Klinika mora biti izabrana")]
        [Display(Name = "Klinika")]
        public int idKlinika { get; set; }
        public int Legalan { get; set; }

        public virtual Klinika Klinika { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recept> Recepts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Termin> Termins { get; set; }
    }
}

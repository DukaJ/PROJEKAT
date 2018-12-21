//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjekatFinalni.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Skola
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Skola()
        {
            this.Kontakt = new HashSet<Kontakt>();
        }
    
        public int SkolaID { get; set; }

        [DisplayName("Naziv �kole:")]
        [Required(ErrorMessage = "Molimo vas unesite naziv �kole.")]
        public string NazivSkole { get; set; }
       

        [DisplayName("Adresa registracije:")]
        [Required(ErrorMessage = "Molimo vas unesite adresu registracije.")]
        public string AdresaRegistracije { get; set; }
      

        [DisplayName("Op�tina:")]
        [Required(ErrorMessage = "Molimo vas unesite ime op�tine.")]
        public string Opstina { get; set; }
       

        [DisplayName("Po�tanski broj:")]
        [Required(ErrorMessage = "Molimo vas unesite po�tanski broj.")]
        public Nullable<int> PostanskiBroj { get; set; }
       

        [DisplayName("Mati�ni broj �kole:")]
        [Required(ErrorMessage = "Molimo vas unesite mati�ni broj �kole")]
        public string MaticniBrojSkole { get; set; }
      

        [DisplayName("PIB:")]
        [Required(ErrorMessage = "Molimo vas unesite PIB.")]
        public string PIB { get; set; }
       

        [DisplayName("Broj ra�una �kole:")]
        [Required(ErrorMessage = "Molimo vas unesite broj ra�una �kole.")]
        public string BrojRacunaSkole { get; set; }


        [DisplayName("Web stranica:")]
        public string WebStranica { get; set; }
     
        public byte[] Fotografija { get; set; }

        [DisplayName("Bele�ka:")]
        public string Beleska { get; set; }
  

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kontakt> Kontakt { get; set; }
    }
}

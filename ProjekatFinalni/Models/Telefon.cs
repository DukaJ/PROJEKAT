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

    public partial class Telefon
    {
        [DisplayName("Broj telefona:")]
        public string BrojTelefona { get; set; }

        [DisplayName("Tip:")]
        public string OznakaTipa { get; set; }

        [DisplayName("Lokal:")]
        public string Lokal { get; set; }

        [DisplayName("Kontakt ID:")]
        public int KontaktID { get; set; }
    
        public virtual Kontakt Kontakt { get; set; }
    }
}

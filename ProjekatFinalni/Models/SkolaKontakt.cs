using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjekatFinalni.Models
{
    public class SkolaKontakt
    {
        public int SkolaID { get; set; }

        [DisplayName("Naziv škole:")]
        [Required(ErrorMessage = "Molimo vas unesite naziv škole.")]
        public string NazivSkole { get; set; }


        [DisplayName("Adresa registracije:")]
        [Required(ErrorMessage = "Molimo vas unesite adresu registracije.")]
        public string AdresaRegistracije { get; set; }


        [DisplayName("Opština:")]
        [Required(ErrorMessage = "Molimo vas unesite ime opštine.")]
        public string Opstina { get; set; }


        [DisplayName("Poštanski broj:")]
        [Required(ErrorMessage = "Molimo vas unesite poštanski broj.")]
        public Nullable<int> PostanskiBroj { get; set; }


        [DisplayName("Matični broj škole:")]
        [Required(ErrorMessage = "Molimo vas unesite matični broj škole")]
        public string MaticniBrojSkole { get; set; }


        [DisplayName("PIB:")]
        [Required(ErrorMessage = "Molimo vas unesite PIB.")]
        public string PIB { get; set; }


        [DisplayName("Broj računa škole:")]
        [Required(ErrorMessage = "Molimo vas unesite broj računa škole.")]
        public string BrojRacunaSkole { get; set; }


        [DisplayName("Web stranica:")]
        public string WebStranica { get; set; }


        [DisplayName("Beleška:")]
        public string Beleska { get; set; }

        [DisplayName("Ime:")]
        [Required(ErrorMessage = "Molimo vas unesite ime kontakta.")]
        public string Ime { get; set; }


        [DisplayName("Prezime:")]
        [Required(ErrorMessage = "Molimo vas unesite prezime kontakta.")]
        public string Prezime { get; set; }


        [DisplayName("Radno mesto:")]
        [Required(ErrorMessage = "Molimo vas unesite radno mesto kontakta.")]
        public string RadnoMesto { get; set; }

        [DisplayName("Kontakt ID:")]
        public int KontaktID { get; set; }

        [DisplayName("Broj telefona:")]
        [Required(ErrorMessage = "Molimo vas unesite broj telefona.")]
        public string BrojTelefona { get; set; }

        [DisplayName("Tip:")]
        [Required(ErrorMessage = "Molimo vas unesite tip.")]
        public string OznakaTipa { get; set; }

        [DisplayName("Lokal:")]
        [Required(ErrorMessage = "Molimo vas unesite lokal.")]
        public string Lokal { get; set; }

        [DisplayName("Adresa:")]
        [Required(ErrorMessage = "Molimo vas unesite Email adresu.")]
        public string Adresa { get; set; }
       

        [DisplayName("Tip:")]
        [Required(ErrorMessage = "Molimo vas unesite tip.")]
        public string OznakaTipaMail { get; set; }
       

        public List<Kontakt> Kontakti { get; set; }

        [DisplayName("Pečat:")]
        public string Fotografija { get; set; }

        public HttpPostedFileBase SlikaFajl { get; set; }

    }
}
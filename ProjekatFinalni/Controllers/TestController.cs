using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjekatFinalni.Models;

namespace ProjekatFinalni.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var skola = new SkolaKontakt();
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(SkolaKontakt skolica1)
        {
            BazaProjekatEntities bazaSkola = new BazaProjekatEntities();

            if (ModelState.IsValid)
            {


                Skola s = new Skola();
                s.NazivSkole = skolica1.NazivSkole;
                s.AdresaRegistracije = skolica1.AdresaRegistracije;
                s.Opstina = skolica1.Opstina;
                s.PostanskiBroj = skolica1.PostanskiBroj;
                s.MaticniBrojSkole = skolica1.MaticniBrojSkole;
                s.PIB = skolica1.PIB;
                s.BrojRacunaSkole = skolica1.BrojRacunaSkole;
                s.WebStranica = skolica1.WebStranica;
                //s.Fotografija = skolica1.Fotografija;
                s.Beleska = skolica1.Beleska;
                string fileName = Path.GetFileNameWithoutExtension(skolica1.SlikaFajl.FileName);
                string ext = Path.GetExtension(skolica1.SlikaFajl.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + ext;
                skolica1.Fotografija = "~/Slike/" + fileName;
                s.Fotografija = skolica1.Fotografija;
                fileName = Path.Combine(Server.MapPath("~/Slike/"), fileName);
                skolica1.SlikaFajl.SaveAs(fileName);

                bazaSkola.Skolas.Add(s);
                bazaSkola.SaveChanges();
                int poslednjaskola = s.SkolaID;

                Kontakt k = new Kontakt();

                k.Ime = skolica1.Ime;
                k.Prezime = skolica1.Prezime;
                k.RadnoMesto = skolica1.RadnoMesto;
                k.SkolaID = poslednjaskola;

                bazaSkola.Kontakts.Add(k);
                bazaSkola.SaveChanges();
                int poslednjikontakt = k.KontaktID;

                Telefon t = new Telefon();

                t.BrojTelefona = skolica1.BrojTelefona;
                t.OznakaTipa = skolica1.OznakaTipa;
                t.Lokal = skolica1.Lokal;
                t.KontaktID = poslednjikontakt;

                bazaSkola.Telefons.Add(t);
                bazaSkola.SaveChanges();

                MailAdresa m = new MailAdresa();
                m.Adresa = skolica1.Adresa;
                m.OznakaTipaMail = skolica1.OznakaTipaMail;
                m.KontaktID = poslednjikontakt;

                bazaSkola.MailAdresas.Add(m);
                bazaSkola.SaveChanges();

                return RedirectToAction("Index", "Skola");
            }
            else
                ViewBag.ErrorMessage = "Niste dobro popunili obrazac.";
                return View("Index", skolica1);
                







        }
    }
}
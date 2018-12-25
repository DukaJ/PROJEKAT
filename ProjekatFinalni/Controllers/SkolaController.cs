using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjekatFinalni.Models;
using Rotativa;

namespace ProjekatFinalni.Controllers
{
    public class SkolaController : Controller
    {
        // GET: Skola
        public ActionResult Index()
        {
            BazaProjekatEntities KontakiBaza = new BazaProjekatEntities();
            List<Skola> skole = KontakiBaza.Skolas.ToList();
            return View(skole);
        }



        public ActionResult Edit(int id)
        {
            using (BazaProjekatEntities dbModel = new BazaProjekatEntities())
            {
                var skola = dbModel.Skolas.Where(x => x.SkolaID == id).FirstOrDefault();
                var vm = new SkolaKontakt { SkolaID = id };
                vm.NazivSkole = skola.NazivSkole;
                vm.AdresaRegistracije = skola.AdresaRegistracije;
                vm.Opstina = skola.Opstina;
                vm.PostanskiBroj = skola.PostanskiBroj;
                vm.MaticniBrojSkole = skola.MaticniBrojSkole;
                vm.PIB = skola.PIB;
                vm.BrojRacunaSkole = skola.BrojRacunaSkole;
                vm.WebStranica = skola.WebStranica;
                vm.Fotografija = skola.Fotografija;
                return View(vm);
            }
        }
        [HttpPost]
        public ActionResult Edit(SkolaKontakt spom)
        {
            try
            {
                using (BazaProjekatEntities dbModel = new BazaProjekatEntities())
                {
                    var s = dbModel.Skolas.FirstOrDefault(x => x.SkolaID == spom.SkolaID);
                    s.NazivSkole = spom.NazivSkole;
                    s.AdresaRegistracije = spom.AdresaRegistracije;
                    s.Opstina = spom.Opstina;
                    s.PostanskiBroj = spom.PostanskiBroj;
                    s.MaticniBrojSkole = spom.MaticniBrojSkole;
                    s.PIB = spom.PIB;
                    s.BrojRacunaSkole = spom.BrojRacunaSkole;
                    s.WebStranica = spom.WebStranica;

                    s.Beleska = spom.Beleska;

                    s.Fotografija = spom.Fotografija;


                    dbModel.Entry(s).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            using (BazaProjekatEntities dbModel = new BazaProjekatEntities())
            {
                return View(dbModel.Skolas.Where(x => x.SkolaID == id).FirstOrDefault());
            }
        }

        [HttpPost] 
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (BazaProjekatEntities dbModel = new BazaProjekatEntities())
                {

                    Skola skola = dbModel.Skolas.Where(x => x.SkolaID == id).FirstOrDefault();


                    foreach (var k2 in dbModel.Kontakts.Where(x => x.SkolaID == id).ToList())
                    {
                        dbModel.MailAdresas.RemoveRange(k2.MailAdresas);
                        dbModel.Telefons.RemoveRange(k2.Telefons);
                    }

                    var Kontakt = dbModel.Kontakts.Where(x => x.SkolaID == skola.SkolaID);
                    dbModel.Kontakts.RemoveRange(Kontakt);
                    dbModel.Skolas.Remove(skola);
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProduceTrackingVaccine.Models;
using ProduceTrackingVaccine.ServiceReference1;

namespace ProduceTrackingVaccine.Controllers
{
    public class ProdusenController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            vaksindbEntities dbProdusen = new vaksindbEntities();

            List<produsen> produsen = dbProdusen.produsen.ToList();

            return View(produsen);
        }
        
        // GET: Produsen
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetData()
        {
            using (vaksindbEntities vaksindb = new vaksindbEntities())
            {
                List<vaksin> laporV = vaksindb.vaksin.ToList<vaksin>();
                return Json(new { data = laporV }, JsonRequestBehavior.AllowGet);
            }
        }

        //Add and Edit Data
        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new vaksin());
            else
            {
                using (vaksindbEntities vaksindb = new vaksindbEntities())
                {
                    return View(vaksindb.vaksin.Where(x => x.idVaksin == id).FirstOrDefault<vaksin>());
                }
            }
        }

        //Add end Edit Data
        [HttpPost]
        public ActionResult AddOrEdit(vaksin vak)
        {
            using (vaksindbEntities vaksindb = new vaksindbEntities())
            {
                if (vak.idVaksin == 0)
                {
                    vaksindb.vaksin.Add(vak);
                    vaksindb.SaveChanges();
                    return Json(new { success = true, message = "Saved Successfully" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    vaksindb.Entry(vak).State = EntityState.Modified;
                    vaksindb.SaveChanges();
                    return Json(new { success = true, message = "Updated Successfully" }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        //Delete Data
        [HttpPost]
        public ActionResult Delete(int id)
        {
            using (vaksindbEntities vaksindb = new vaksindbEntities())
            {
                vaksin vak = vaksindb.vaksin.Where(x => x.idVaksin == id).FirstOrDefault<vaksin>();
                vaksindb.vaksin.Remove(vak);
                vaksindb.SaveChanges();
                return Json(new { success = true, message = "Deleted Successfully" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult AddLaporan()
        {
            Service1Client service1Client = new Service1Client();
            return View();
        }
        //Add Laporan
        [HttpPost]
        public ActionResult AddLaporan(int idLaporan, string noRegVaksin)
        {
            Service1Client service1Client = new Service1Client();
            ServiceReference1.laporanvaksin data = new ServiceReference1.laporanvaksin
            {
                idLaporan = idLaporan,
                noRegVaksin = noRegVaksin,
                idProdusen = "Produsen",
                idBPOM = "BPOM",
                status = "Valid"
            };
            if (service1Client.AddLaporanVaksin(data))
            {
                Session["success"] = "true";
            }
            return View();
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Autentikasi");
        }
    }
}
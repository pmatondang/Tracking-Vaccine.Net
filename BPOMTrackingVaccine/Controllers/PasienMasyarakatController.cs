using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BPOMTrackingVaccine.Models;

namespace BPOMTrackingVaccine.Controllers
{
    public class PasienMasyarakatController : Controller
    {
        // GET: PasienMasyarakat
        public ActionResult IndexPasienMasyarakat()
        {
            return View();
        }

        public ActionResult GetData()
        {
            using (vaksindbEntities2 vaksindb = new vaksindbEntities2())
            {
                List<vaksin> laporV = vaksindb.vaksin.ToList<vaksin>();
                return Json(new { data = laporV }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
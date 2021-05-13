using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RSTrackingVaccine.ServiceReference1;
using RSTrackingVaccine.Models;

namespace RSTrackingVaccine.Controllers
{
    public class RSController : Controller
    {
        //GET: Index
        public ActionResult Home()
        {
            return View("Home");
        }

        // GET: RS
        public ActionResult Index()
        {
            Service1Client service1Client = new Service1Client();
            Models.AllList list = new Models.AllList
            {
                ListVaksin = service1Client.GetVaksin(),
                ListPasien = service1Client.GetPasien()
            };
            return View(list);
        }

        [HttpPost]
        public ActionResult Index(string idPelaporanP, string noRegVaksin, string nikPasien, string noRekamMedis)
        {
            Service1Client service1Client = new Service1Client();
            ServiceReference1.pelaporan_penggunaan data = new ServiceReference1.pelaporan_penggunaan
            {
                idPelaporanP = idPelaporanP,
                idBPOM = "BPOM",
                idRS = "RumahSakit",
                noRegVaksin = noRegVaksin,
                nikPasien = nikPasien,
                noRekamMedis = noRekamMedis,
                statusV = "Telah Digunakan"
            };
            if (service1Client.AddLaporanPenggunaan(data))
            {
                Session["success"] = "true";
            }
            Models.AllList list = new Models.AllList
            {
                ListVaksin = service1Client.GetVaksin(),
                ListPasien = service1Client.GetPasien()
            };
            return View(list);
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Autentikasi");
        }

    }
}
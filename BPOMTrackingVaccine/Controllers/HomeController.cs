using BPOMTrackingVaccine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BPOMTrackingVaccine.Controllers
{
    public class HomeController : Controller
    {
        //GET: Index
        public ActionResult Index()
        {
            return View("Index");
        }

            
        // GET: Vaksin
        public ActionResult ViewVaccine()
        {
            vaksindbEntities2 dbVaksin = new vaksindbEntities2();

            List<vaksin> vaksin = dbVaksin.vaksin.ToList();

            return View(vaksin);
        }

        // GET: Pelaporan Vaksin
        public ActionResult ViewVaccineReport()
        {
            vaksindbEntities2 dbLaporan = new vaksindbEntities2();

            List<laporanvaksin> pelaporanvaksin = dbLaporan.laporanvaksin.ToList();

            return View(pelaporanvaksin);
        }

        // GET: Pelaporan Penggunaan
        public ActionResult ViewUsageReport()
        {
            vaksindbEntities2 dbPelaporanPenggunaan = new vaksindbEntities2();

            List<pelaporan_penggunaan> pelaporan_penggunaan = dbPelaporanPenggunaan.pelaporan_penggunaan.ToList();

            /*var JoinViewModel = from pp in pelaporan_Penggunaan
                                join ps in pasien on pp.nikPasien equals ps.nikPasien
                                into pps
                                from ps in pps.DefaultIfEmpty()
                                select new JoinPasienPelaporanPenggunaan { pasien = ps, pelaporan_Penggunaan = pp };

            return View(JoinViewModel);*/
            return View(pelaporan_penggunaan);
        }

        // GET: Pelaporan Vaksin
        public ActionResult Produsen()
        {
            vaksindbEntities2 dbProdusen = new vaksindbEntities2();

            List<produsen> produsen = dbProdusen.produsen.ToList();

            return View(produsen);
        }

        // GET: Pelaporan Vaksin
        public ActionResult Pasien()
        {
            vaksindbEntities2 dbPasien = new vaksindbEntities2();

            List<pasien> pasien = dbPasien.pasien.ToList();

            return View(pasien);
        }

        // GET: Pelaporan Vaksin
        public ActionResult Hospital()
        {
            vaksindbEntities2 hospital = new vaksindbEntities2();

            List<rumah_sakit> rumah_Sakit = hospital.rumah_sakit.ToList();

            return View(rumah_Sakit);
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Autentikasi");
        }
    }
}
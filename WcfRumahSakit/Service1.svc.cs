using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfRumahSakit
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool AddLaporanPenggunaan(pelaporan_penggunaan data)
        {
            vaksindbEntities vaksindbEntities = new vaksindbEntities();
            if (data != null)
            {
                vaksindbEntities.pelaporan_penggunaan.Add(data);
                vaksindbEntities.SaveChanges();
                vaksindbEntities.Dispose();

                return true;
            }
            else
            {
                vaksindbEntities.Dispose();
                return false;
            }
        }
        /*public bool UpdateLaporanPenggunaan(pelaporan_penggunaan data)
        {
            vaksindbEntities vaksindbEntities = new vaksindbEntities();
            pelaporan_penggunaan newData = vaksindbEntities.pelaporan_penggunaan.FirstOrDefault(x => x.idPelaporanP.Equals(data.idPelaporanP));
            if (data != null)
            {
                newData

            }
            vaksindbEntities.Dispose();
            return false;
        }*/

        public bool DeleteLaporanPenggunaan(string idPelaporanP)
        {
            vaksindbEntities vaksindbEntities = new vaksindbEntities();
            pelaporan_penggunaan data = vaksindbEntities.pelaporan_penggunaan.FirstOrDefault(x => x.idPelaporanP.Equals(idPelaporanP));
            if (data != null)
            {
                vaksindbEntities.pelaporan_penggunaan.Remove(data);
                vaksindbEntities.SaveChanges();
                vaksindbEntities.Dispose();

                return true;
            }
                vaksindbEntities.Dispose();
                return false;
        }

        public IEnumerable<pasien> GetPasien()
        {
            vaksindbEntities vaksindbEntities = new vaksindbEntities();
            IEnumerable<pasien> listPasien = vaksindbEntities.pasien.ToList();

            return listPasien;
        }

        public IEnumerable<vaksin> GetVaksin()
        {
            vaksindbEntities vaksindbEntities = new vaksindbEntities();
            IEnumerable<vaksin> listVaksin = vaksindbEntities.vaksin.ToList();

            return listVaksin;
        }

    }
}

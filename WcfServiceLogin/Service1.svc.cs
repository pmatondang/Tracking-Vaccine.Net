using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceLogin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //Autentikasi Actor
        public bool Login(string username, string password)
        {
            vaksindbEntities vaksindbEntities = new vaksindbEntities();

            akun GetAccount = vaksindbEntities.akun.FirstOrDefault(x => x.username.Equals(username) && x.password.Equals(password));

            if (GetAccount != null)
            {
                vaksindbEntities.Dispose();
                return true;
            }

            return false;
        }

        public akun GetAccount(string username)
        {
            vaksindbEntities vaksindbEntities = new vaksindbEntities();

            akun GetAccount = vaksindbEntities.akun.FirstOrDefault(x => x.username.Equals(username));
            vaksindbEntities.Dispose();
            return GetAccount;
        }

        public akun Pendaftaran(akun data)
        {
            vaksindbEntities vaksindbEntities = new vaksindbEntities();

            int jlh = vaksindbEntities.akun.Count();
            vaksindbEntities.akun.Add(data);
            int jlh2 = vaksindbEntities.akun.Count();
            if (jlh2 > jlh)
            {
                return data;
            }
            return null;
        }
    }
}

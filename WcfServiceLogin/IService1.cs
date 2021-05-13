using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceLogin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        //Autentikasi
        [OperationContract]
        akun Pendaftaran(akun data);

        [OperationContract]
        bool Login(string username, string password);

        [OperationContract]
        akun GetAccount(string username);
    }
}

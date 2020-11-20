using Phone_Book_DB;
using Phone_Book_DB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Tik_Kanale_Alternative.Model;

namespace Tik_Kanale_Alternative
{
    /// <summary>
    /// Summary description for PhoneBookService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PhoneBookService : System.Web.Services.WebService
    {
       // Makina a = new Makina();

        public readonly PhoneBookServicesDb serviceDb = new PhoneBookServicesDb();


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }



        [WebMethod]
        public bool IsCoonected()
        {
            return serviceDb.IsConnected();
        }


        [WebMethod]
        public PhoneBookModel GetById(long id)
        {
            return new PhoneBookModel();
        }

    }
}

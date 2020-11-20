using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Book_DB.Services
{
  public  class PhoneBookServicesDb
    {
      

        public bool IsConnected()
        {

            bool isConnected = false;
            using(PHONE_BOOK_DBEntities db = new PHONE_BOOK_DBEntities())
            {
                isConnected = true;
            }

            return isConnected;
        }

       
    }
}

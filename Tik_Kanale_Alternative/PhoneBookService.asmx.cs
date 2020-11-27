using Phone_Book_DB;
using Phone_Book_DB.Services;
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
            PhoneBookModel model = new PhoneBookModel();
            if (id > 0)
            {
                model.Preselect(serviceDb.GetById(id));
                return model;
            }

            else
            {

                return model;
            }

        }

        [WebMethod]
        public string Save(PhoneBookModel model)
        {
            if (model != null)
            {
                T_PHONE_BOOK item = new T_PHONE_BOOK();
                model.Fill(item);
                if (serviceDb.Save(item))
                {
                    return "Elementi u shtua me sukses";
                }

                else
                {
                    return "Probleme gjate shtimit";
                }
            }
            else
            {
                return "Specifikoni  nje objekt te vlefshem";
            }
        }

        [WebMethod]
        public string Put(PhoneBookModel model)
        {
            if (model != null && model.Id.HasValue)
            {

                if (model.Id > 0)
                {
                    T_PHONE_BOOK item = serviceDb.GetById(model.Id.Value);
                    if (item != null)
                    {
                        model.Fill(item);
                        if (serviceDb.Put(item))
                        {
                            return "Elementi u modifikua me sukses";
                        }

                        else
                        {
                            return "Probleme gjate modifikimit";
                        }
                    }
                    else
                    {
                        return "Objekti nuk u gjet ne bazen e te dhenave";
                    }
                }
                else { return "Specifikoni nje ID te vlefshme per modelin"; }
            }
            else
            {
                return "Vendosni nje objekt te vlefshem";
            }
        }


        [WebMethod]
        public string Delete(long id)
        {
            if (id > 0)
            {
                T_PHONE_BOOK item = serviceDb.GetById(id);
                if (item != null)
                {
                    if (serviceDb.Delete(item))
                    {
                        return "Objekti u fshi me sukses";
                    }

                    else
                    {
                        return "Probleme gjate fshirjes";
                    }
                }
                else
                {
                    return "Objekti nuk u gjet ne bazen e te dhenave";
                }
            }
            else
            {
                return "Specifikoni nje id te vlefshme";
            }
        }


        [WebMethod]
        public string DeleteFizik(long id)
        {
            if (id > 0)
            {
                T_PHONE_BOOK item = serviceDb.GetById(id);
                if (item != null)
                {
                    if (serviceDb.DeleteFizik(item))
                    {
                        return "Objekti u fshi me sukses";
                    }

                    else
                    {
                        return "Probleme gjate fshirjes";
                    }
                }
                else
                {
                    return "Objekti nuk u gjet ne bazen e te dhenave";
                }
            }
            else
            {
                return "Specifikoni nje id te vlefshme";
            }
        }
    }
}

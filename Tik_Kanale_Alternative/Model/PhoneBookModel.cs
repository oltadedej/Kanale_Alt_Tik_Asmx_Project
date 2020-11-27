using Phone_Book_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tik_Kanale_Alternative.Model
{
    [Serializable]
    public class PhoneBookModel
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? IdPhoneType { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? InsertedDate { get; set; }
        public string Number { get; set; }


        /// <summary>
        /// KONVERTON NJE OBJEKT TE TIPIT PHONEBOOKMODEL NE T_PHONE_BOOK
        /// </summary>
        /// <param name="item"></param>
        public void Fill(T_PHONE_BOOK item)
        {
            item.NAME = this.Name;
            item.SURNAME = this.Surname;
            item.NUMBER = this.Number;
            item.ID_PHONE_TYPE = this.IdPhoneType;

        }

        /// <summary>
        /// Konverton nje objekt te tipit T_PHONE_BOOK NE  phonebookmodel
        /// </summary>
        /// <param name="item"></param>
        public void Preselect (T_PHONE_BOOK item)
        {
            if (item != null)
            {
                this.Id = item.ID;
                this.Name = item.NAME;
                this.Surname = item.SURNAME;
                this.Number = item.NUMBER;
                this.IdPhoneType = item.ID_PHONE_TYPE;
            }

        }
        

    }
}
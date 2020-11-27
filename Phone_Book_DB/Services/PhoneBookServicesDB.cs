using System;
using System.Linq;

namespace Phone_Book_DB.Services
{
    public class PhoneBookServicesDb
    {
        public bool IsConnected()
        {

            bool isConnected = false;
            using (PHONE_BOOK_DBEntities db = new PHONE_BOOK_DBEntities())
            {
                isConnected = true;
            }

            return isConnected;
        }


        public T_PHONE_BOOK GetById(long Id)
        {
            using (PHONE_BOOK_DBEntities db = new PHONE_BOOK_DBEntities())
            {
                return db.T_PHONE_BOOK.ToList().Where(i => i.ID == Id && !i.DELETED_DATE.HasValue).FirstOrDefault();
            }
        }


        public bool Save(T_PHONE_BOOK item)
        {
            bool isInserted = false;
            try
            {
                if (item != null)
                {
                    using (PHONE_BOOK_DBEntities db = new PHONE_BOOK_DBEntities())
                    {
                        item.INSERTED_DATE = DateTime.Now;
                        db.T_PHONE_BOOK.Add(item);
                        db.SaveChanges();
                        isInserted = true;

                    }

                }

            }
            catch (Exception ex)
            {
                // write logs into log file
            }

            return isInserted;
        }

        public bool Put(T_PHONE_BOOK item)
        {
            bool IsUpdated = false;
            try
            {
                if (item != null)
                {
                    using (PHONE_BOOK_DBEntities db = new PHONE_BOOK_DBEntities())
                    {
                        item.MODIFIED_DATE = DateTime.Now;
                        db.T_PHONE_BOOK.Add(item);
                        db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        IsUpdated = true;

                    }

                }

            }
            catch (Exception ex)
            {
                // write logs into log file
            }

            return IsUpdated;
        }



        /// <summary>
        /// Delete Logjik
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Delete(T_PHONE_BOOK item)
        {
            bool IsDeleted = false;
            try
            {
                if (item != null)
                {
                    using (PHONE_BOOK_DBEntities db = new PHONE_BOOK_DBEntities())
                    {
                        item.DELETED_DATE = DateTime.Now;
                        db.T_PHONE_BOOK.Add(item);
                        db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        IsDeleted = true;

                    }

                }

            }
            catch (Exception ex)
            {
                // write logs into log file
            }

            return IsDeleted;
        }


        /// <summary>
        /// Delete fizik
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool DeleteFizik(T_PHONE_BOOK item)
        {
            bool IsDeleted = false;
            try
            {
                if (item != null)
                {
                    using (PHONE_BOOK_DBEntities db = new PHONE_BOOK_DBEntities())
                    {
                       db.T_PHONE_BOOK.Attach(item);
                        db.T_PHONE_BOOK.Remove(item);
                        db.SaveChanges();
                        IsDeleted = true;

                    }

                }

            }
            catch (Exception ex)
            {
                // write logs into log file
            }

            return IsDeleted;
        }
    }
}

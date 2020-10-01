using RetaDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetaService
{
    public class CustomerService
    {
        RetaDbEntities db = new RetaDbEntities();

        public void AddCustomer(CUSTOMERS customer)
        {
            db.CUSTOMERS.Add(customer);
            db.SaveChanges();
        }

   

        public List<CUSTOMERS> CustomerList()
        {
            List<CUSTOMERS> customerList = new List<CUSTOMERS>();
            customerList = db.CUSTOMERS.ToList();
            return customerList;

        }
        public void DeleteCustomer(int deger)
        {
            var sil = db.CUSTOMERS.Where(m => m.ID == deger).FirstOrDefault();
            db.CUSTOMERS.Remove(sil);
            db.SaveChanges();
        }

        public void UpdateCustomer(int degisken,CUSTOMERS customer)
        {
            CUSTOMERS customer_old = db.CUSTOMERS.Where(m => m.ID == degisken).FirstOrDefault();
        
            customer_old.MAIL = customer.MAIL;
            customer_old.NAME = customer.NAME;
            customer_old.PHONE = customer.PHONE;
            customer_old.SURNAME = customer.SURNAME;
            db.SaveChanges();
        }
    }
}

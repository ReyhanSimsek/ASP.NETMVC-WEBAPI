using RetaDAL;
using RetaService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetaMVCUI.Controllers
{
    public class CustomerController : Controller
    {

        CustomerService cs = new CustomerService();
        // GET: Customer
        public ActionResult Index()
        {
            List<CUSTOMERS> list=cs.CustomerList();
            return View(list);
        }
        public ActionResult Create(CUSTOMERS customer)
        {
            cs.AddCustomer(customer);
            return RedirectToAction("index");
        }
        public ActionResult Delete(int id)
        {
            cs.DeleteCustomer(id);
            return RedirectToAction("index");
        }

        public ActionResult Update(int id,CUSTOMERS customer)
        {
            cs.UpdateCustomer(id, customer);
            return RedirectToAction("index");

        }
        public ActionResult Edit(int id)
        {
            RetaDbEntities db = new RetaDbEntities();
            var mus = db.CUSTOMERS.Find(id);
            return View(mus);
        }
        [HttpPost]
        public ActionResult Edit(int id, CUSTOMERS customer)
        {
            RetaDbEntities db = new RetaDbEntities();
            var mus = db.CUSTOMERS.Find(id);
            mus.SURNAME = customer.SURNAME;
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
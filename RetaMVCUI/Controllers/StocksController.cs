using RetaDAL;
using RetaService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetaMVCUI.Controllers
{
    public class StocksController : Controller
    {
        // GET: Stocks
        StockService cs = new StockService();
        // GET: Customer
        public ActionResult Index()
        {
            List<STOCKS> list = cs.StockList();
            return View(list);
        }

        public ActionResult Create(STOCKS Stock)
        {
            cs.AddStock(Stock);
            return RedirectToAction("index");
        }
        public ActionResult Delete(int id)
        {
            cs.DeleteStock(id);
            return RedirectToAction("index");
        }

        public ActionResult Update(int id, STOCKS Stock)
        {
            cs.UpdateStock(id, Stock);
            return RedirectToAction("index");

        }
    }
}
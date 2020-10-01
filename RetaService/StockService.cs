using RetaDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace RetaService
{
    public class StockService
    {
        RetaDbEntities db = new RetaDbEntities();

        public void AddStock(STOCKS Stock)
        {
            db.STOCKS.Add(Stock);
            db.SaveChanges();
        }

        public List<STOCKS> StockList()
        {
            List<STOCKS> StockList = new List<STOCKS>();
            StockList = db.STOCKS.ToList();
            return StockList;

        }

        public void DeleteStock(int deger)
        {
            var sil = db.STOCKS.Where(m => m.ID == deger).FirstOrDefault();
            db.STOCKS.Remove(sil);
            db.SaveChanges();
        }

        public void UpdateStock(int degisken, STOCKS Stock)
        {
            STOCKS Stock_old = db.STOCKS.Where(m => m.ID == degisken).FirstOrDefault();

            Stock_old.STOCKCODE = Stock.STOCKCODE;
            Stock_old.NAME = Stock.NAME;
            Stock_old.QUANTITY = Stock.QUANTITY;

            db.SaveChanges();
        }

    }

}

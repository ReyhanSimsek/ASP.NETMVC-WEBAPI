using RetaDAL;
using RetaService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetaConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerService cs = new CustomerService();
            string sayi;
            string deger;
            string degisken;
            while (true)
            {
                Console.WriteLine("*************************************************");
                Console.WriteLine("1: Veri Listeleme");
                Console.WriteLine("2: Veri Ekleme");
                Console.WriteLine("3: Veri Silme");
                Console.WriteLine("4: Veri Güncelleme");
                Console.WriteLine("Seçiminiz:");
                sayi = Console.ReadLine();
                Console.WriteLine("*************************************************");

                if (sayi == "1")
                {
                    foreach (var item in cs.CustomerList())
                    {
                        Console.WriteLine(item.ID + " " + item.NAME + " " + item.SURNAME + " " + item.PHONE + " " + item.MAIL);
                    }
                }
                else if (sayi == "2")
                {
                    CUSTOMERS customer = new CUSTOMERS();
                    Console.Write("Adınız");
                    customer.NAME = Console.ReadLine();
                    Console.Write("Soyadınız");
                    customer.SURNAME = Console.ReadLine();
                    Console.Write("Telefon");
                    customer.PHONE = Console.ReadLine();
                    Console.Write("Mail");
                    customer.MAIL = Console.ReadLine();
                    cs.AddCustomer(customer);
                }
                else if(sayi=="3")
                {
                    Console.WriteLine("Hangi idli kaydı silmek istiyorsunuz?");
                    deger = Console.ReadLine();
                    cs.DeleteCustomer(Convert.ToInt32(deger));
                }
                else if(sayi=="4")
                {
                    Console.WriteLine("Hangi idli kaydı gincellemek istiyorsunuz?");
                    degisken = Console.ReadLine();

                    RetaDbEntities db = new RetaDbEntities();

                    CUSTOMERS customer = new CUSTOMERS();
                    Console.Write("Adınız");
                    customer.NAME = Console.ReadLine();
                    Console.Write("Soyadınız");
                    customer.SURNAME = Console.ReadLine();
                    Console.Write("Telefon");
                    customer.PHONE = Console.ReadLine();
                    Console.Write("Mail");
                    customer.MAIL = Console.ReadLine();

                    cs.UpdateCustomer(Convert.ToInt32(degisken),customer);
                   
                }
                
            }




            //cs.AddCustomer();
            cs.CustomerList();

            Console.ReadKey();
        }
    }
}

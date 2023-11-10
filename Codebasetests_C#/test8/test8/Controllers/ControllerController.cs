using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test8.Controllers
{
    public class ControllerController : Controller
    {
        // GET: Controller
        private NorthwindEntities db = new NorthwindEntities();

        public ActionResult CInG()
        {
            var gC = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(gC);
        }

        // Second action method: Get customer details with orderId == 10248
        public ActionResult CustomerDetails()
        {
            var customerD = db.Orders
                .Where(o => o.OrderID == 10248)
                .Select(o => o.Customer)
                .FirstOrDefault();

            return View(customerD);
        }
    }
}
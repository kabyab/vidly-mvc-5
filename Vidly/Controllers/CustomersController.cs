using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly List<Customer> _customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "John Williams" },
            new Customer { Id = 2, Name = "Mary Smith" },
            new Customer { Id = 3, Name = "Harold Hargrove" }
        };
        // GET: Customers
        public ActionResult Index()
        {
            return View(_customers);
        }

        public ActionResult Details(int id)
        {
            try
            {
                var customer = _customers.SingleOrDefault(cus => cus.Id == id);
                if (customer == null)
                    return HttpNotFound();
                return View(customer);
            }
            catch (NullReferenceException)
            {
                return HttpNotFound();
            }
        }
    }
}

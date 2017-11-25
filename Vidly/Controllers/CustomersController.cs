using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        //private readonly List<Customer> _customers = new List<Customer>
        //{
        //    new Customer { Id = 1, Name = "John Williams" },
        //    new Customer { Id = 2, Name = "Mary Smith" },
        //    new Customer { Id = 3, Name = "Harold Hargrove" }
        //};
        private readonly ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            try
            {
                var customer = _context.Customers.SingleOrDefault(cus => cus.Id == id);
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

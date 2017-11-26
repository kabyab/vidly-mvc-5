using System;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    /// <summary>
    /// The Customer controller handles every event of the "Customers" tab
    /// </summary>
    public class CustomersController : Controller
    {
        //  private readonly List<Customer> _customers = new List<Customer>
        //  {
        //      new Customer { Id = 1, Name = "John Williams" },
        //      new Customer { Id = 2, Name = "Mary Smith" },
        //      new Customer { Id = 3, Name = "Harold Hargrove" }
        //  };

        /// <summary>
        /// The global ApplicationDbContext field, helps fetch all the objects that are mapped to our database
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Constructor to initialize the ApplicationDbContext object
        /// </summary>
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        /// <summary>
        /// Dispose method overriden to ensure garbage collection
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        /// <summary>
        /// Action to GET all Customers from database
        /// </summary>
        /// <returns>IEnumerable<Customer></returns>
        public ActionResult Index()
        {
            // The MembershipType being a navigation type has to be included separately
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        /// <summary>
        /// Returns the details of a Customer with the given Id
        /// </summary>
        /// <param name="id">The Id of the Customer whose details are requested</param>
        /// <returns>Customer Object</returns>
        public ActionResult Details(int id)
        {
            try
            {
                var customer = _context.Customers.SingleOrDefault(cus => cus.Id == id);
                if (customer == null) // If Customer with given Id does not exist
                    return HttpNotFound();
                return View(customer);
            }
            catch (NullReferenceException)
            {
                // If ApplicationDbContext is not initialized
                return HttpNotFound();
            }
        }
    }
}

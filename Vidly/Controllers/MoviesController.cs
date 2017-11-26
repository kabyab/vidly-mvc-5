using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModels;
using System;

namespace Vidly.Controllers
{
    /// <summary>
    /// The Movies controller handles every event of the "Movies" tab.
    /// </summary>
    public class MoviesController : Controller
    {
        /// <summary>
        /// The global ApplicationDbContext field, helps fetch all the objects that are mapped to our database
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Constructor to initialize the ApplicationDbContext object
        /// </summary>
        public MoviesController()
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
        /// Displays the list of movies available.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
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
                var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(mov => mov.Id == id);
                if (movie == null) // If Customer with given Id does not exist
                    return HttpNotFound();
                return View(movie);
            }
            catch (NullReferenceException)
            {
                // If ApplicationDbContext is not initialized
                return HttpNotFound();
            }
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}

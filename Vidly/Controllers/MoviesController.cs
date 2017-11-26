using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    /// <summary>
    /// The Movies controller handles every event of the "Movies" tab.
    /// </summary>
    public class MoviesController : Controller
    {
        /// <summary>
        /// Test Method. Gets a random list of movies and customers
        /// </summary>
        /// <returns></returns>
        public ViewResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var movieViewModel = new RandomMovieViewModel
            {
                Movie =  movie,
                Customers =  customers
            };

            return View(movieViewModel);
        }

        /// <summary>
        /// Test Method to check parameter passing to URL
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        /// <summary>
        /// Displays the list of movies available. (Need to add database call)
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var movies = new List<Movie>()
            {
                new Movie {Name = "Shrek!"},
                new Movie {Name = "Inception"},
                new Movie {Name = "Wall-E"}
            };

            return View(movies);
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}

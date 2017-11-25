using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
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

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        // movies
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
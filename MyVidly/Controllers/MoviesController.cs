using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyVidly.Models;
using MyVidly.ViewModels;
using System.Data.Entity;

namespace MyVidly.Controllers
{

    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController() 
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var genreList = _context.Genres.ToList();
            var viewModel = new MoviesFormViewModel
            {
                Genres = genreList
            };
            return View("MoviesForm",viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movies movies)
        {
            if (!ModelState.IsValid)
            {
                this.ModelState.AddModelError("Movies_Name", "Lagyan mo ng laman!");
                this.ModelState.AddModelError("Movies_GenreId", "Lagyan mo ng laman!");
                this.ModelState.AddModelError("Movies_ReleasedDate", "Lagyan mo ng laman!");
            }
            if (movies.Id == 0)
            {
                movies.DateAdded = DateTime.Now;
                _context.Movies.Add(movies);
            }
            else
            {
                var moviesInDb = _context.Movies.Single(m => m.Id == movies.Id);
                moviesInDb.Name = movies.Name;
                moviesInDb.GenreId = movies.GenreId;
                moviesInDb.ReleasedDate = movies.ReleasedDate;
                moviesInDb.DateAdded = movies.DateAdded;
            }
            _context.SaveChanges();

            return RedirectToAction("Index","Movies");
        }
        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies) ;
        }

        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movies == null)
            {
                return HttpNotFound(); 
            }

            return View(movies);
        }

        public ActionResult Edit(int id)
        {
            var movies = _context.Movies.SingleOrDefault(m => m.Id == id);
            var viewModel = new MoviesFormViewModel
            {
                Movies = movies,
                Genres = _context.Genres.ToList()
            };

            if (movies == null)
                return HttpNotFound();
            return View("MoviesForm", viewModel);
        }

    }
}
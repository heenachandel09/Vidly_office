using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            { Name="Shrek!"};

            return View(movie);
        }
        public ActionResult Edit(int id)
        {
            return Content("ID"+id);
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = '1';
            
            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        public ActionResult RenderMovie()
        {
            var mv = new List<Movie>
            {
               new Movie {Id=1, Name="Fast and Furious"},
               new Movie {Id=2, Name="The Meg" },
               new Movie {Id=3, Name="Shrek" }
            };
            ViewBag.movies = mv;
            return View();
        }
    }

   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab_21_Movie_Registration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_21_Movie_Registration.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult ShowMovieResults()
        {
            List<MovieModel> Movies = new List<MovieModel>();
            Movies.Add(new MovieModel(1, "The Wizard of Oz", "Sci-Fi", 1939, "Judy Garland", "Victor Fleming"));
            Movies.Add(new MovieModel(2, "Get Out", "Suspense/Thriller", 2017, "Daniel Kaluuya, Allison Williams, Lil Rel Howery", "Jordan Peele"));
            Movies.Add(new MovieModel(3, "Like a Boss", "Comedy", 2020, "Tiffany Haddish, Selma Hayek, Rose Byrne", "Miguel Arteta"));
            Movies.Add(new MovieModel(4, "Rush Hour", "Action", 1998, "Jackie Chan, Chris Tucker, Ken Leung, Tom Wilkinson", "Brett Ratner"));

            ViewBag.Movies_List = Movies;
            return View();
        }

        public IActionResult ShowMovieResultSummary(MovieModel movie)
        {
            return View(movie);
        }

        public IActionResult AddAMovie()
        {
            return RedirectToAction("Registration");
        }

        public IActionResult OnPost(MovieModel movie)
        {
            if(ModelState.IsValid)
            {
                List<MovieModel> Movies = new List<MovieModel>();
                Movies.Add(movie);
                return RedirectToPage("ShowMovieResults");
            }
            else
            {
                return View();
            }

        }

        public IActionResult ShoppingCart()
        {
            return View();
        }

        public IActionResult Receipt()
        {
            return View();
        }
    }
}

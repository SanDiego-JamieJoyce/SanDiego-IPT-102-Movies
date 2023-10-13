using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;
using static System.Net.WebRequestMethods;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
 
           
            new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance, Drama", link = "https://www.youtube.com/embed/kVrqfYjkTdQ?si=uGPBS7-maJlj0OGr"},
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction, Thriller", link = "https://www.youtube.com/embed/8hP9D6kZseM?si=HTWI8KMQfH00Gh-A" },
            new MovieViewModel { Id = 3, Name = "Ma", Rating = "5", ReleaseYear = 2019, Genre = "Horror, Mystery, Thriller", link = "https://www.youtube.com/embed/eIvbEC8N3cA?si=LtKz8cTizNLF9E3A" },

            new MovieViewModel { Id = 4, Name = "Talk to me", Rating = "2.2", ReleaseYear = 2022, Genre = "Horror, Thriller", link = "https://www.youtube.com/embed/aLAKJu9aJys?si=ShLZuvu0YclzmtU8" },
            new MovieViewModel { Id = 5, Name = "X", Rating = "2.2", ReleaseYear = 2022, Genre = "Horror, Mystery, Thriller", link = "https://www.youtube.com/embed/KKih6hZSQBA?si=lkzvTMexcTdyh1K3" },
            new MovieViewModel { Id = 6, Name = "Batman", Rating = "2.8", ReleaseYear = 2022, Genre = "Actioion, Drama, Crime", link = "https://www.youtube.com/embed/mqqft2x_Aa4?si=FSv5pekcpzrmUx28" },
            new MovieViewModel { Id = 7, Name = "Babylon", Rating = "2.1", ReleaseYear = 2022, Genre = "Comedy, Drama, History", link = "https://www.youtube.com/embed/5muQK7CuFtY?si=8IyF1rE53Mmr1SnY" },
            new MovieViewModel { Id = 8, Name = "The Menu", Rating = "2.2", ReleaseYear = 2022, Genre = "Drama, Horror, Thriller", link = "https://www.youtube.com/embed/C_uTkUGcHv4?si=mz0NPIVRW_f-A1D5" },
            new MovieViewModel { Id = 9, Name = "Pearl", Rating = "2", ReleaseYear = 2022, Genre = "Drama, Horror, Thriller", link = "https://www.youtube.com/embed/L5PW5r3pEOg?si=7v1vgKFC9xllo7s3" },
            new MovieViewModel { Id = 10, Name = "Barbarian", Rating = "2", ReleaseYear = 2022, Genre = "Horror, Mystery, Thriller", link = "https://www.youtube.com/embed/Dr89pmKrqkI?si=aibT58DTE-SnMlm_" },
            new MovieViewModel { Id = 11, Name = "Tenet", Rating = "2.3", ReleaseYear = 2020, Genre = "Action, Sci-Fi, Thriller", link = "https://www.youtube.com/embed/L3pk_TBkihU?si=UWPn917AGh6KJ_So" },
            new MovieViewModel { Id = 12, Name = "Soul", Rating = "3", ReleaseYear = 2020, Genre = "Animation, Adventure, Comedy", link = "https://www.youtube.com/embed/xOsLIiBStEs?si=csc9tyxLPdS19KTA" },
            new MovieViewModel { Id = 13, Name = "Mank", Rating = "1.8", ReleaseYear = 2020, Genre = "Biography, Comedy, Drama", link = "https://www.youtube.com/embed/aSfX-nrg-lI?si=-6OdVTlzgMxn3Akf" },
            new MovieViewModel { Id = 14, Name = "Joker", Rating = "3.4", ReleaseYear = 2019, Genre = "Crime, Drama, Thriller", link = "https://www.youtube.com/embed/zAGVQLHvwOY?si=rmFMvtw9TedOJjyI" },
            new MovieViewModel { Id = 15, Name = "Glass", Rating = "1.6", ReleaseYear = 2019, Genre = "Drama, Horror, Sci-Fi", link = "https://www.youtube.com/embed/95ghQs5AmNk?si=q3HlSf9oXwDRlm3W" },

        };
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


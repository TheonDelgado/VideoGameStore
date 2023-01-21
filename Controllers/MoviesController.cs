using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGameStore.Data;

namespace VideoGameStore.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext context;

        public MoviesController(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index() 
        {
            var allMovies = await context.Movies.ToListAsync();

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGameStore.Data;

namespace VideoGameStore.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext context;

        public CinemasController(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index() 
        {
            var allCinemas = await context.Cinemas.ToListAsync();

            return View(allCinemas);
        }
    }
}
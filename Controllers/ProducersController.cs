using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGameStore.Data;

namespace VideoGameStore.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext context;

        public ProducersController(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()  
        {
            var allProducers = await context.Producers.ToListAsync();

            return View();
        }
    }
}
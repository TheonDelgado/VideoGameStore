using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoGameStore.Data;

namespace VideoGameStore.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext context;

        public ActorsController(AppDbContext context)
        {
            this.context = context;
        }


        public IActionResult Index() 
        {
            var data = context.Actors.ToList();

            return View(data);
        }
    }
}
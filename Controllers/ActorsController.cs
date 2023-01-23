using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoGameStore.Data;
using VideoGameStore.Data.Services;

namespace VideoGameStore.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService service;

        public ActorsController(IActorsService service)
        {
            this.service = service;
        }


        public async Task<IActionResult> Index() 
        {
            var data =  await service.GetAll();

            return View(data);
        }
    }
}
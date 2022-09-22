using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Frontend.Controllers
{
    public class ConsultaRestaurantController : Controller
    {
        private readonly RestaurantDbContext _context;

        public IActionResult Index()
        {
            return View();
        }

        //PARCIAL VIEW CONSULTA
        public async Task<ActionResult> _ViewAllConsulta()
        {
            var model = await _context.Restaurants.ToListAsync();
            return PartialView("_ViewAllConsulta", model);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CargoExpress.Models;
using Microsoft.EntityFrameworkCore;

namespace CargoExpress.Controllers
{
    public class HomeController : Controller
    {
        private DBCargo db;
        public HomeController(DBCargo context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpGet]
        public IActionResult Order()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Order(Client client)
        {
            db.Clients.Add(client);
            await db.SaveChangesAsync();
            return RedirectToAction("Thanks");
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Tariff()
        {
            return View();
        }

        public IActionResult Branch()
        {
            return View();
        }

        public IActionResult Calculate()
        {
            return View();
        }

        public async Task<IActionResult> DataClient()
        {
            return View(await db.Clients.ToListAsync());
        }

        [HttpGet]
        public IActionResult Information()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Information(string Admin, int Password)
        {
            if (Admin == "Vitalik2301" && Password == 23012001)
            {
                return RedirectToAction("DataClient");
            }
            return View();
        }


        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Client user = await db.Clients.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null)
                    return View(user);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Client user = await db.Clients.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null)
                {
                    db.Clients.Remove(user);
                    await db.SaveChangesAsync();
                    return RedirectToAction("DataClient");
                }
            }
            return NotFound();
        }

        public IActionResult Thanks()
        {
            return View();
        }

        public IActionResult Geolocation()
        {
            return View();
        }
    }
}

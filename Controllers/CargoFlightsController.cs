using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineTicket.Models;

namespace OnlineTicket.Controllers
{
    public class CargoFlightsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CargoFlights
        public ActionResult Index()
        {
            return View(db.cargo.ToList());
        }
    }
}

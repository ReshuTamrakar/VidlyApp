using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyApp.Models;

namespace VidlyApp.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
       
        public ActionResult Details(int id)
        {
            var customer = _context.customers.Include(c=> c.MembershipType).SingleOrDefault(c => c.Id == id);
            if(customer== null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
        // GET: Customer
        public ActionResult Index()
        {
            var customers = _context.customers.Include(c=> c.MembershipType).ToList();
            return View(customers);
   
        }
    }
}
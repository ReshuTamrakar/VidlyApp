﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyApp.Models;

namespace VidlyApp.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //GET: Movies
        public ActionResult Index()
        {
            var movies = _context.movies.Include(m=> m.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = _context.movies.Include(m =>m.Genre).SingleOrDefault(m=> m.Id==id);

            if(movies== null)
            {
                return HttpNotFound();
            }
            return View(movies);
        }
    }
}
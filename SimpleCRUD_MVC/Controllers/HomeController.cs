using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleCRUD_MVC.Models;

namespace SimpleCRUD_MVC.Controllers
{
    public class HomeController : Controller
    {
        PersonContext db = new PersonContext();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var person = db.people.ToList();

            return View(person);
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            var person = db.people.Find(id);

            return View(person);
        }

        //
        // GET: /Home/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(Person person)
        {
            db.people.Add(person);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        //
        // GET: /Home/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var person = db.people.Find(id);

            return View(person);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            db.Entry(person).State = System.Data.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        //
        // GET: /Home/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var person = db.people.Find(id);

            return View(person);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult Delete(Person person)
        {
            db.Entry(person).State = System.Data.EntityState.Deleted;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}

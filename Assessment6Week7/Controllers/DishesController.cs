﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assessment6Week7.Models;

namespace Assessment6Week7.Controllers
{
    [Authorize]
    public class DishesController : Controller
    {
        private TaylorEvertsPartyDBEntities db = new TaylorEvertsPartyDBEntities();

        // GET: Dishes
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(db.Dishes.ToList());
        }

        // GET: Dishes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dish dish = db.Dishes.Find(id);
            if (dish == null)
            {
                return HttpNotFound();
            }
            return View(dish);
        }

        // GET: Dishes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dishes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DishID,PersonName,PhoneNumber,DishName,DishDescription,Option")] Dish dish)
        {
            if (ModelState.IsValid)
            {
                dish.PersonName = User.Identity.Name;
                db.Dishes.Add(dish);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dish);
        }

        // GET: Dishes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dish dish = db.Dishes.Find(id);
            if (dish == null)
            {
                return HttpNotFound();
            }
            return View(dish);
        }

        // POST: Dishes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DishID,PersonName,PhoneNumber,DishName,DishDescription,Option")] Dish dish)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dish).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dish);
        }

        // GET: Dishes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dish dish = db.Dishes.Find(id);
            if (dish == null)
            {
                return HttpNotFound();
            }
            return View(dish);
        }

        // POST: Dishes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dish dish = db.Dishes.Find(id);
            db.Dishes.Remove(dish);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult YourDishes()
        {
            var email = User.Identity.Name;
            return View(db.Dishes.Where(x => x.PersonName == email).ToList());
        }
    }
}

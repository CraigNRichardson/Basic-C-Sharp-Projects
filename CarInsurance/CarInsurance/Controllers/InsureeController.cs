﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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



        [HttpPost]
        public ActionResult Premium(string firstName, string lastName, string emailAddress, DateTime dateOfBirth,
                                    int carYear, string carMake, string carModel, int speedingTickets,
                                    bool coverageType = false, bool dui = false, decimal quote = 50)
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insuree = new Insuree();
                insuree.FirstName = firstName;
                insuree.LastName = lastName;
                insuree.EmailAddress = emailAddress;
                insuree.DateOfBirth = dateOfBirth;
                insuree.CarYear = carYear;
                insuree.CarMake = carMake;
                insuree.CarModel = carModel;
                insuree.DUI = dui;
                insuree.SpeedingTickets = speedingTickets;
                insuree.CoverageType = coverageType;

                var today = DateTime.Today;
                var age = today.Year - dateOfBirth.Year;

                if (age <= 18)
                {
                    quote += 100;
                }

                if (age >= 19 && age <= 25)
                {
                    quote += 50;
                }

                if (age > 25)
                {
                    quote += 25;
                }

                if (carYear < 2000)
                {
                    quote += 25;
                }

                if (carYear > 2015)
                {
                    quote += 25;
                }

                if (carMake == "Porsche")
                {
                    quote += 25;
                }

                if (carMake == "Porsche" && carModel == "911 Carrera")
                {
                    quote += 25;
                }

                if (speedingTickets > 0)
                {
                    quote += (speedingTickets*10);
                }

                if (dui == true)
                {
                    quote *= Convert.ToDecimal(1.25);
                }

                if (coverageType == true)
                {
                    quote *= Convert.ToDecimal(1.50);
                }

                insuree.Quote = quote;

                db.Insurees.Add(insuree);
                db.SaveChanges();
            }
            ViewBag.Message = ("Your Monthly insurance premium will be: $" + (quote).ToString("#.00"));
            return View("Success");
        }

        public ActionResult Quote()
        {
            return View();
        }

        public ActionResult Success()
        {
            
            return View();
        }
    }
}

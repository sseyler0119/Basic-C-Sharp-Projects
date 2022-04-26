using System;
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
                GetQuote(insuree.Id);
                return RedirectToAction("Details", new { Id = insuree.Id }); // display quote
            }
            return View(insuree);
        }

        // Calculates Insurance Quote based on information passed in from form
        public ActionResult GetQuote(int Id)
        {
            using(InsuranceEntities db = new InsuranceEntities())
            {
                var insuree = db.Insurees.Find(Id);

                decimal baseQuote = 50.00m; // base rate of $50.00

                // calculate age
                DateTime today = DateTime.Now; // current date
                var age = today.Subtract(insuree.DateOfBirth).TotalDays; // calculate age in # of days
                int ageInYears = Convert.ToInt32(age / 365); //calculate age in years

                // calculate additional monthly cost based on age
                if (ageInYears <= 18)
                {
                    baseQuote += 100; // add $100 if insuree < 18
                }
                else if (ageInYears >= 19 && ageInYears <= 25)
                {
                    baseQuote += 50; // add $50 to baseQuote if insuree age is between 19-25
                }
                else
                {
                    baseQuote += 25; // add $25 to baseQuote if insuree age > 25
                }

                // if CarYear is before year 2000 or after 2015, add $25 to baseQuote
                if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                {
                    baseQuote += 25;
                }

                // if CarMake is a Porcsche add $25 to baseQuote
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    baseQuote += 25;
                    // if CarModel is 911 Carrera add $25 to baseQuote
                    if (insuree.CarModel.ToLower() == "911 carrera")
                    {
                        baseQuote += 25;
                    }
                }

                // calcuate additional monthly cost based on # of speeding tickets
                if (insuree.SpeedingTickets > 0)
                {
                    // add $10 for each speeding ticket to baseQuote
                    baseQuote += (insuree.SpeedingTickets * 10);
                }

                if (insuree.DUI) // insuree has a DUI
                {
                    baseQuote += (baseQuote * .25m); // add 25 % to baseQuote
                }

                // Insuree is requesting full coverage
                if (insuree.CoverageType)
                {
                    baseQuote += (baseQuote * .5m);
                }

                insuree.Quote = baseQuote; // finalized quote
                db.SaveChanges();
                return RedirectToAction("Details", new { Id = insuree.Id });
            }
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

       
    }
}

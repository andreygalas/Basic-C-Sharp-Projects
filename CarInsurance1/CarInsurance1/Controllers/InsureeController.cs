using System.Web.Mvc;
using System.Collections.Generic;
using System;
using CarInsurance1.Models;

namespace InsuranceQuotes.Controllers
{
    public class InsureeController : Controller
    {
        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Calculate the base monthly total
                decimal monthlyTotal = 50;

                // Age calculations
                int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                if (age <= 18)
                    monthlyTotal += 100;
                else if (age >= 19 && age <= 25)
                    monthlyTotal += 50;
                else if (age >= 26)
                    monthlyTotal += 25;

                // Car year calculations
                if (insuree.CarYear < 2000)
                    monthlyTotal += 25;
                else if (insuree.CarYear > 2015)
                    monthlyTotal += 25;

                // Car make calculations
                if (insuree.CarMake.ToLower() == "porsche")
                {
                    monthlyTotal += 25;
                    if (insuree.CarModel.ToLower() == "911 carrera")
                        monthlyTotal += 25;
                }

                // Speeding ticket calculations
                monthlyTotal += 10 * insuree.SpeedingTickets;

                // DUI calculation
                if (insuree.DUI)
                    monthlyTotal *= 1.25m;

                // Full coverage calculation
                if (insuree.CoverageType)
                    monthlyTotal *= 1.5m;

                insuree.Quote = monthlyTotal;

                // Save the insuree to the database or any other data store
                // Code to save the insuree goes here

                return RedirectToAction("Confirmation");
            }

            return View(insuree);
        }

        // GET: Insuree/Confirmation
        public ActionResult Confirmation()
        {
            return View();
        }

        // GET: Insuree/AdminView
        public ActionResult AdminView()
        {
            // Retrieve all insuree records with their first name, last name, email, and quote
            List<Insuree> allInsurees = new List<Insuree>();
            // Code to retrieve all insuree records goes here

            return View(allInsurees);
        }
    }
}
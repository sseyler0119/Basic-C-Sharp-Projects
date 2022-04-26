using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var quoteVms = new List<QuoteVM>();
                var quotes = db.Insurees.Where(x => x.Quote >= 0).ToList(); // send quotes to list

                foreach(var q in quotes) // map to database
                {
                    var quoteVm = new QuoteVM();
                    quoteVm.FirstName = q.FirstName;
                    quoteVm.LastName = q.LastName;
                    quoteVm.EmailAddress = q.EmailAddress;
                    quoteVm.Quote = q.Quote;
                    quoteVms.Add(quoteVm);
                }
                return View(quoteVms);
            }

            return View();
        }
    }
}
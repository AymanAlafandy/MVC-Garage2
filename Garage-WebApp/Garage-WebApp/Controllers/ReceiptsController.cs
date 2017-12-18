using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Garage_WebApp.DataAccessLayer;
using Garage_WebApp.Models.ViewModel;
using Garage_WebApp.Models;

namespace Garage_WebApp.Controllers
{
    public class ReceiptsController : Controller
    {
        private RegisterContext db = new RegisterContext();

      

        // GET: Receipts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ParkedVehicle Vehicle = db.Vehicle.Find(id);
            Receipt receipt = new Receipt(Vehicle);
            if (receipt == null)
            {
                return HttpNotFound();
            }
            return View(receipt);
        }


        public ActionResult Receipts(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ParkedVehicle Vehicle = db.Vehicle.Find(id);
            Receipt receipt = new Receipt(Vehicle);
            if (receipt == null)
            {
                return HttpNotFound();
            }
            return View(receipt);
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

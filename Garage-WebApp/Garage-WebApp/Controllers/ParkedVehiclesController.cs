using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Garage_WebApp.DataAccessLayer;
using Garage_WebApp.Models;
using Garage_WebApp.Models.ViewModel;

namespace Garage_WebApp.Controllers
{
    public class ParkedVehiclesController : Controller
    {
        public RegisterContext db = new RegisterContext();

        // GET: ParkedVehicles
        public ActionResult Index()
        {
            return View(db.Vehicle.ToList());
        }
        //public ActionResult SelectType()
        //{
        //    List<SelectListItem> item = new List<SelectListItem>();
        //    item.Add(new SelectListItem { Text = "Car", Value = "0" });
        //    item.Add(new SelectListItem { Text = "Bus", Value = "1" });
        //    item.Add(new SelectListItem { Text = "Motocycle", Value = "2" });
        //    item.Add(new SelectListItem { Text = "Airplane", Value = "3" });
        //    item.Add(new SelectListItem { Text = "Boat", Value = "4" });


        //    return View(Index);
        //}
        public ActionResult VehicleList()
        {
            List<ParkedVehicle> model = new List<ParkedVehicle>();
            foreach(var p in db.Vehicle.ToList())
            {
                model.Add(p);
            }
            //var model = db.Vehicle.Where(p => p.Color == "VehicleList").ToList();
            return View(model);
        }

        public ActionResult VehicleType()
        {
            var model = db.VehicleTypes.ToList();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(/**/string searchBy, string search)
        {
            if (searchBy== "RegistrationNumber") //search
            {
                return View(db.Vehicle.Where(x => x.RegNr.ToString().Contains(search)).ToList());
            }
            else
            {
                return View(db.Vehicle.ToList());
            }
        }


        // GET: ParkedVehicles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.Vehicle.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Create
        public ActionResult Create()
        {

            ViewBag.VehicleTypeId = new SelectList(db.VehicleTypes, "Id", "Type");

            return View();
        }

        // POST: ParkedVehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type,RegNr,Color,Brand,Model,NumberOfWheels,ParkingTime")] ParkedVehicle parkedVehicle)
        {
          
            if (ModelState.IsValid)
            {
               var model = db.Vehicle.Add(parkedVehicle);
                parkedVehicle.ParkingTime = DateTime.Now;
                db.SaveChanges();
                return View(model);
            }
            //ViewBag.VehicleTypeId = new SelectList(db.VehicleTypes, "Id", "Type");

            return View(db.Vehicle.ToList());
        }

        // GET: ParkedVehicles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.Vehicle.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            ViewBag.VehicleTypeId = new SelectList(db.VehicleTypes, "Id", "Type");
            db.SaveChanges();
            return View(parkedVehicle);
        }

        // POST: ParkedVehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Type,RegistrationNumber,Color,Brand,Model,NumberOfWheels")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parkedVehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.Vehicle.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);
        }


        // POST: ParkedVehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ParkedVehicle parkedVehicle = db.Vehicle.Find(id);
            db.Vehicle.Remove(parkedVehicle);
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

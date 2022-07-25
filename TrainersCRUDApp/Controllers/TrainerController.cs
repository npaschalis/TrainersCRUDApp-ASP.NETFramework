using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrainersCRUDApp.DataAccess.Repository;
using TrainersCRUDApp.Models;

namespace TrainersCRUDApp.Controllers
{
    public class TrainerController : Controller
    {
        private readonly TrainerRepository _tr;

        public TrainerController()
        {
            _tr = new TrainerRepository();
        }

        public ActionResult Index()
        {
            IEnumerable<Trainer> objTrainerList = _tr.GetAll();
            return View(objTrainerList);
        }


        // Create: GET
        public ActionResult Create()
        {
            return View();
        }

        // Create: POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Trainer obj)
        {
            if (ModelState.IsValid) 
            {
                _tr.Add(obj);
                _tr.Save();
                TempData["success"] = "Trainer created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        // Edit: GET
        public ActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var trainerFromDb = _tr.GetFirstOrDefault(u => u.Id == id);

            if (trainerFromDb == null)
            {
                return HttpNotFound();
            }

            return View(trainerFromDb);

        }

        // Edit: POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Trainer obj)
        {
            if (ModelState.IsValid)
            {
                _tr.Update(obj);
                TempData["success"] = "Trainer updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // Delete: GET
        public ActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var trainerFromDb = _tr.GetFirstOrDefault(u => u.Id == id);

            if (trainerFromDb == null)
            {
                return HttpNotFound();
            }

            return View(trainerFromDb);

        }

        // Delete: POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePOST(int? id)
        {
            var obj = _tr.GetFirstOrDefault(u => u.Id == id);

            if (obj == null)
            {
                return HttpNotFound();
            }

            _tr.Remove(obj);
            _tr.Save();
            TempData["success"] = "Trainer deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
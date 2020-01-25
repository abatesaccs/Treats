using System;
using Microsoft.AspNetCore.Mvc;
using SweetTreat.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;


namespace SweetTreat.Controllers
{
    
    public class FlavorsController : Controller
    {
        private readonly SweetTreatContext _db;

        public FlavorsController(SweetTreatContext db)
        {
            _db = db;
        }

        public async Task<ActionResult> Index()
        {
            return View(_db.Flavors.ToList());
        }
        [Authorize]
        public ActionResult Create()
        {   
            ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "TreatName");
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Flavor flavor, int TreatId)
        {
            _db.Flavors.Add(flavor);
            if (TreatId != 0)
            {
                _db.TreatFlavor.Add(new TreatFlavor() { TreatId = TreatId, FlavorId = flavor.FlavorId });
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details( int id)
        {
            var thisFlavor = _db.Flavors
                .Include(flavor => flavor.Treats)
                .ThenInclude(join => join.Treat)
                .FirstOrDefault(flavors => flavors.FlavorId == id);
            return View(thisFlavor);
        }
        [Authorize]
        public ActionResult Edit(int id)
        {   
            var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
            ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "TreatName");
            return View(thisFlavor);
        }

        [HttpPost]
        public ActionResult Edit(Flavor flavor, int TreatId)
        {
            if (TreatId !=0)
            {
                _db.TreatFlavor.Add(new TreatFlavor() {TreatId = TreatId, FlavorId = flavor.FlavorId});
            }
            _db.Entry(flavor).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult AddTreat(int id)
        {
        var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
        ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "TreatName");
        return View(thisFlavor);
        }

        [HttpPost]
        public ActionResult AddTreat(Flavor flavor, int TreatId)
        {
        if (TreatId != 0)
        {
            _db.TreatFlavor.Add(new TreatFlavor() { TreatId = TreatId, FlavorId = flavor.FlavorId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult Delete(int id)
        {
            var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
            return View(thisFlavor);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisFlavor = _db.Flavors.FirstOrDefault(flavors => flavors.FlavorId == id);
            _db.Flavors.Remove(thisFlavor);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteTreat(int joinId)
        {
            var joinEntry = _db.TreatFlavor.FirstOrDefault(entry => entry.TreatFlavorId == joinId);
            _db.TreatFlavor.Remove(joinEntry);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Search()
        {   
            return View();
        }
        [HttpPost]
        public ActionResult Search (string FlavorName)
        {   
            try
            {
                var searchItem = _db.Flavors.First(flavors => flavors.FlavorName == FlavorName);
                return RedirectToAction("SearchDetails", "Flavors", searchItem);
            }
            catch (Exception e)
            {
                return RedirectToAction("SearchDetails", "Flavors");
            } 
        }
        [ActionName("SearchDetails")]
        public ActionResult SearchDetails(string FlavorName)
        {
            var searchItems = _db.Flavors.Where(flavors => flavors.FlavorName == FlavorName).ToList();
            System.Console.WriteLine(FlavorName);
            System.Console.WriteLine(searchItems);
            return View("SearchDetails", searchItems);
        }
    }
}
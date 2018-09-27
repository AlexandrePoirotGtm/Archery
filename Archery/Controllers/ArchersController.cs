using Archery.Models;
using System;
using System.Web.Mvc;

namespace Archery.Controllers
{
    public class ArchersController : Controller
    {
        // GET: Players
        public ActionResult Subscribe()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Subscribe(Archer archer)
        {
            //if (DateTime.Compare(archer.BirthDate.AddYears(9), DateTime.Today) >= 0)
            //{
            //    ViewBag.Erreur = "L'age est trop jeune";
            //    return View();
            //    ModelState.AddModelError("BirthDate", "Date de naissance invalide");
            //}
            if (ModelState.IsValid)
            {
                // return BadRequest(ModelState);
            }
            return View();
        }
    }
}
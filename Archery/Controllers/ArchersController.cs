using Archery.Data;
using Archery.Models;
using System;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using Archery.Tools;

namespace Archery.Controllers
{
    public class ArchersController :  BaseController
    {
        // GET: Players
        public ActionResult Subscribe()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Subscribe([Bind(Exclude = "ID")]Archer archer)
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
                archer.Password = Crypto.GenerateMD5(archer.Password);
                db.Archers.Add(archer);
                db.SaveChanges();

                Display("Bravo a toi, tu a réussi la création d'un tireur");
                //return View();
                return RedirectToAction("index", "home");
            }
            else
            {
                Display("Raté",Tools.MessageType.ERROR);
            }
            return View();
        }
    }

}
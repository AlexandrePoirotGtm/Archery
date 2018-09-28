using Archery.Data;
using Archery.Models;
using System;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using Archery.Tools;

namespace Archery.Controllers
{
    public abstract class BaseController : Controller
    {
        protected ArcheryDbContext db = new ArcheryDbContext();

        protected void Display(string text, MessageType messageType = MessageType.SUCCESS)
        {
            var m = new Message(messageType, text);
            TempData["MESSAGE"] = m;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (!disposing)
                this.db.Dispose();
        }
    }
}
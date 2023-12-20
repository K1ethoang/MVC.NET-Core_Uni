using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai_3.Controllers
{
    public class MusicController : Controller
    {
        // GET: Music
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listen(String musicName)
        {
            ViewBag.MusicName = musicName;
            return View();
        }
        public ActionResult Download(string musicName)
        {
            var filePath = Server.MapPath("~/Content/music/" + musicName + ".mp3");

            if (System.IO.File.Exists(filePath))
            {
                return File(filePath, "audio/mpeg", musicName + ".mp3");
            }
            else
            {
                return HttpNotFound();
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalendarSample.Controllers
{
  public class HomeController : Controller
  {
    // GET: Home
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Eventos(string s, string e)
    {
      DateTime start = DateTime.Parse(s);
      DateTime end = DateTime.Parse(e);
      return Json(new object[]
      {
        new { title = "Tarea", start = start.AddDays(5), end = start.AddDays(7) },
        new { title = "Evento", start = start.AddDays(6), end = start.AddDays(9) },
        new { title = "Reunion", start = start.AddDays(10), end = start.AddDays(15) }
      }, JsonRequestBehavior.AllowGet);
    }
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC_app2.Controllers
{
    public class HolidayController : Controller
    {
        private HolidayRandomiser randHoliday;
        //
        // GET: /Holiday/
        public ActionResult Index()
        {
            randHoliday = new HolidayRandomiser();
            
            return View(randHoliday.GetHoliday());
        }
	}
}
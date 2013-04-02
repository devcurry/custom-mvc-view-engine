using MVC40_CustomViewEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC40_CustomViewEngine.Controllers
{
    public class EmployeeInfoController : Controller
    {
        //
        // GET: /EmployeeInfo/

        public ActionResult Index()
        {
            var Emps = new DataAccess().GetEmps();
            ViewData.Model = Emps;
            return View("DataView");
        }

    }
}

using ExerciseCode.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExerciseCode.Controllers.Account
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult LoginProcess(LoginProcessParamModel loginProcessParamModel)
        {
            try
            {

            }
            catch(Exception ex)
            {
                Console.WriteLine("[Login][LoginProcess] Exception Error");
            }

            return Json("result", "success");
        }
    }
}
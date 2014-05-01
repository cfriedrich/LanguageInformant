using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LangInformant.Domain.Entities;
using LangInformant.Domain.Concrete;

namespace LangInformant.WebUI.Controllers
{
    public class RegistrationController : Controller
    {

        public ViewResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User info)
        {
            //ToDO

            return RedirectToAction("Index");
        }

    }
}

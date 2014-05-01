using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lang_Inform.Domain.Concrete;
using Lang_Inform.Domain.Entities;

namespace Lang_Inform.WebUI.Controllers
{
    public class HomeController : Controller
    {
        Lang_InformDbContext langContext = new Lang_InformDbContext();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Word testWord = new Word { Name = "Word", Description = "Test Word" };
            langContext.Words.Add(testWord);
            Meaning testMeaning = new Meaning { Name = "Part of speech" };
            langContext.Meanings.Add(testMeaning);
            langContext.SaveChanges();
            
            

            return View();
        }

    }
}

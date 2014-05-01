using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LangInformant.Domain.Abstract;
using LangInformant.Domain.Concrete;
using LangInformant.Domain.Entities;

namespace LangInformant.WebUI.Controllers
{
    public class MeaningController : Controller
    {
            private IMeaningRepository repository;

            public MeaningController(IMeaningRepository meaningRepository)
            {
                this.repository = meaningRepository;
            }

            public ActionResult Index()
            {
                return View();
            }

            public ViewResult List()
            {
                return View(repository.GetMeanings());
            }

            public ViewResult AddMeaning()
            {
                return View();
            }

            [HttpPost]
            public ViewResult AddMeaning(Meaning meaning)
            {
                repository.AddMeaning(meaning);
                return View();
            }

            public ViewResult EditMeaning(int meaningId)
            {
                Meaning thisMeaning = repository.GetMeaning(meaningId);
                return View(thisMeaning);
            }

            [HttpPost]
            public ActionResult EditMeaning(Meaning meaning)
            {
                if (ModelState.IsValid)
                {
                    repository.SaveMeaning(meaning);
                    TempData["message"] = string.Format("{0} has been saved", meaning.Name);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // There is something wrong with the data values

                    return View(meaning);
                }
            }

            public ViewResult DeleteMeaning(int meaningId)
            {
                Meaning thisMeaning = repository.GetMeaning(meaningId);
                return View(thisMeaning);
            }

            [HttpPost]
            public ActionResult DeleteMeaning(Meaning meaning)
            {
                repository.DeleteMeaning(meaning.MeaningID);

                return RedirectToAction("Index", "Home");

            }

            public ViewResult MeaningDetails(int meaningId)
            {
                Meaning thisMeaning = repository.GetMeaning(meaningId);
                return View(thisMeaning);
            }

        }
    }

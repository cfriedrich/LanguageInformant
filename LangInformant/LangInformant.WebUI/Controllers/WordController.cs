using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LangInformant.Domain.Entities;
using LangInformant.Domain.Concrete;
using LangInformant.Domain.Abstract;
using LangInformant.WebUI.Controllers;

namespace LangInformant.WebUI.Controllers
{
    public class WordController : Controller
    {        
        private IWordRepository repository;

        public WordController(IWordRepository wordRepository)
        {
            this.repository = wordRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult List()
        {
            return View(repository.GetWords());
        }

        public ViewResult AddWord()
        {
            return View();
        }
        
        [HttpPost]
        public ViewResult AddWord(Word word)
        {
            repository.AddWord(word);
            return View();
        }

        public ViewResult EditWord(int wordId)
        {
            Word thisWord = repository.GetWord(wordId);
            return View(thisWord);
        }

        [HttpPost]
        public ActionResult EditWord(Word word)
        {
            if (ModelState.IsValid)
            {
                repository.SaveWord(word);
                TempData["message"] = string.Format("{0} has been saved", word.Name);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // There is something wrong with the data values

                return View(word);
            }
        }

        public ViewResult DeleteWord(int wordId)
        {
            Word thisWord = repository.GetWord(wordId);
            return View(thisWord);
        }

        [HttpPost]
        public ActionResult DeleteWord(Word word)
        {
            repository.DeleteWord(word.WordID);

            return RedirectToAction("Index", "Home");

        }

        public ViewResult WordDetails(int wordId)
        {
            Word thisWord = repository.GetWord(wordId);
            return View(thisWord);
        }

    }
}

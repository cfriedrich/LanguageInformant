using LangInformant.Domain.Abstract;
using LangInformant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LangInformant.WebUI.Controllers
{
    public class LessonController : Controller
    {
        private ILessonRepository repository;

        public LessonController(ILessonRepository lessonRepository)
        {
            this.repository = lessonRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult List()
        {
            return View(repository.GetLessons());
        }

        public ViewResult AddLesson()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddLesson(Lesson lesson)
        {
            repository.AddLesson(lesson);
            return View();
        }

        public ViewResult EditLesson(int lessonId)
        {
            Lesson thisLesson = repository.GetLesson(lessonId);
            return View(thisLesson);
        }

        [HttpPost]
        public ActionResult EditLesson(Lesson lesson)
        {
            if (ModelState.IsValid)
            {
                repository.SaveLesson(lesson);
                TempData["message"] = string.Format("{0} has been saved", lesson.Name);
                return RedirectToAction("Index", "Lesson");
            }
            else
            {
                // There is something wrong with the data values

                return View(lesson);
            }
        }

        public ViewResult DeleteLesson(int lessonId)
        {
            Lesson thisLesson = repository.GetLesson(lessonId);
            return View(thisLesson);
        }

        [HttpPost]
        public ActionResult DeleteLesson(Lesson lesson)
        {
            repository.DeleteLesson(lesson.LessonID);

            return RedirectToAction("Index", "Home");

        }

        public ViewResult LessonDetails(int lessonId)
        {
            Lesson thisLesson = repository.GetLesson(lessonId);
            return View(thisLesson);
        }
    }
}

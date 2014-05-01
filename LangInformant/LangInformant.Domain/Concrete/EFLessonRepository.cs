﻿using LangInformant.Domain.Abstract;
using LangInformant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangInformant.Domain.Concrete
{
    public class EFLessonRepository : ILessonRepository
    {
        public IQueryable<Lesson> GetLessons()
        {
            var db = new LangInformantDbContext();
            return (from l in db.Lessons select l);
        }

        public void AddLesson(Lesson lesson)
        {
            var db = new LangInformantDbContext();
            db.Lessons.Add(lesson);
            db.SaveChanges();
        }

        public void SaveLesson(Lesson lesson)
        {
            var db = new LangInformantDbContext();

            if (lesson.LessonID == 0)
            {
                db.Lessons.Add(lesson);
                db.SaveChanges();
            }
            else
            {
                Lesson dbEntry = db.Lessons.Find(lesson.LessonID);
                if (dbEntry != null)
                {
                    dbEntry.Name = lesson.Name;
                    dbEntry.Description = lesson.Description;
                    dbEntry.Unit = lesson.Unit;
                    dbEntry.Vocabularies = lesson.Vocabularies;
                    dbEntry.Scenes = lesson.Scenes;

                    db.SaveChanges();
                }
            }
        }

        public Lesson DeleteLesson(int lessonID)
        {
            var db = new LangInformantDbContext();
            Lesson dbEntry = db.Lessons.Find(lessonID);
            if (dbEntry != null)
            {
                db.Lessons.Remove(dbEntry);
                db.SaveChanges();
            }
            return dbEntry;
        }



        public Lesson GetLesson(int lessonID)
        {
            var db = new LangInformantDbContext();
            Lesson dbEntry = db.Lessons.Find(lessonID);

            return dbEntry;
        }
    }
}

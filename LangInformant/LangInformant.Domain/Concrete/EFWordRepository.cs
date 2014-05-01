using LangInformant.Domain.Abstract;
using LangInformant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LangInformant.Domain.Concrete
{
    public class EFWordRepository : IWordRepository
    {

        public IQueryable<Word> GetWords()
        {
            var db = new LangInformantDbContext();
            return (from w in db.Words select w);
        }

        public void AddWord(Word word)
        {
            var db = new LangInformantDbContext();
            db.Words.Add(word);
            db.SaveChanges();
        }

        public void SaveWord(Word word)
        {
            var db = new LangInformantDbContext();
            
            if (word.WordID == 0)
            {
                db.Words.Add(word);
                db.SaveChanges();
            }
            else
            {
                Word dbEntry = db.Words.Find(word.WordID);
                if (dbEntry != null)
                {
                    dbEntry.Name = word.Name;
                    dbEntry.Description = word.Description;
                    dbEntry.Sound = word.Sound;
                    dbEntry.Meanings = word.Meanings;
                    dbEntry.Language = word.Language;
                    dbEntry.SoundVol = word.SoundVol;
                    db.SaveChanges();
                }
            }
        }

        public Word DeleteWord(int wordID)
        {
            var db = new LangInformantDbContext();
            Word dbEntry = db.Words.Find(wordID);
            if (dbEntry != null)
            {
                db.Words.Remove(dbEntry);
                db.SaveChanges();
            }
            return dbEntry;
        }



        public Word GetWord(int wordID)
        {
            var db = new LangInformantDbContext();
            Word dbEntry = db.Words.Find(wordID);

            return dbEntry;
        }
    }
}

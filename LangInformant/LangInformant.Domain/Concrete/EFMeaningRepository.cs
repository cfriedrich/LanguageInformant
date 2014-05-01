using LangInformant.Domain.Abstract;
using LangInformant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangInformant.Domain.Concrete
{
     public class EFMeaningRepository : IMeaningRepository
    {

        public IQueryable<Meaning> GetMeanings()
        {
            var db = new LangInformantDbContext();
            return (from m in db.Meanings select m);
        }

        public void AddMeaning(Meaning meaning)
        {
            var db = new LangInformantDbContext();
            db.Meanings.Add(meaning);
            db.SaveChanges();
        }

        public void SaveMeaning(Meaning meaning)
        {
            var db = new LangInformantDbContext();
            
            if (meaning.MeaningID == 0)
            {
                db.Meanings.Add(meaning);
                db.SaveChanges();
            }
            else
            {
                Meaning dbEntry = db.Meanings.Find(meaning.MeaningID);
                if (dbEntry != null)
                {
                    dbEntry.Name = meaning.Name;
                    dbEntry.Description = meaning.Description;
                    dbEntry.Picture = meaning.Picture;
                    dbEntry.Words = meaning.Words;
                    db.SaveChanges();
                }
            }
        }

        public Meaning DeleteMeaning(int meaningID)
        {
            var db = new LangInformantDbContext();
            Meaning dbEntry = db.Meanings.Find(meaningID);
            if (dbEntry != null)
            {
                db.Meanings.Remove(dbEntry);
                db.SaveChanges();
            }
            return dbEntry;
        }



        public Meaning GetMeaning(int meaningID)
        {
            var db = new LangInformantDbContext();
            Meaning dbEntry = db.Meanings.Find(meaningID);

            return dbEntry;
        }
    }
}

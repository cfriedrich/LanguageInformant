using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lang_Inform.Domain.Entities;
using System.Data.Entity;

namespace Lang_Inform.Domain.Concrete
{
    public class Lang_InformDbContext:DbContext
    {
        public DbSet<Language> Languages { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Meaning> Meanings { get; set; }
        public DbSet<Phrase> Phrases { get; set; }
        public DbSet<Scene> Scenes { get; set; }
        public DbSet<SentenceBuilding> SentenceBuildings { get; set; }
        public DbSet<SentenceBuildingItemPicture> SentenceBuildingItemPictures { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vocabulary> Vocabularies { get; set; }
        public DbSet<Word> Words { get; set; }
    }
}

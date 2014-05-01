using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LangInformant.Domain.Entities;

namespace LangInformant.Domain.Concrete
{
    public class LangInformantDbContext:DbContext
    {
        public DbSet<Language> Languages { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Meaning> Meanings { get; set; }
        public DbSet<Phrase> Phrases { get; set; }
        public DbSet<Scene> Scenes { get; set; }
        public DbSet<User> Users {get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Vocabulary> Vocabularies { get; set; }
        public DbSet<Word> Words { get; set; }
    }
}

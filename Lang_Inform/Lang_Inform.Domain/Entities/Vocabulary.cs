using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Inform.Domain.Entities
{
    public class Vocabulary
    {
        public int VocabularyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Lesson Lesson { get; set; }
        public IList<Word> Words = new List<Word>();
    }
}

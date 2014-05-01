using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Inform.Domain.Entities
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Unit Unit { get; set; }

        public IList<Scene> Scenes { get; set; }
        public IList<Vocabulary> Vocabularies { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Inform.Domain.Entities
{
    public class SentenceBuildingItem
    {
        public int SentenceBuildingItemId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int SentenceBuildingItemPictureId { get; set; }
        public int PhraseId { get; set; }
        public SentenceBuildingItemPicture Picture { get; set; }
        public IList<Word> Words = new List<Word>();
    }
}

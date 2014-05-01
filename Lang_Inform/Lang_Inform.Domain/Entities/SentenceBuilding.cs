using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Inform.Domain.Entities
{
    public class SentenceBuilding
    {
        public int SentenceBuildingId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public IList<SentenceBuildingItem> SentenceBuildingItems = new List<SentenceBuildingItem>();

    }
}

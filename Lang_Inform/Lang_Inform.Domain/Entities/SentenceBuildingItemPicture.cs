using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Inform.Domain.Entities
{
    public class SentenceBuildingItemPicture
    {
        public int SentenceBuildingItemPictureId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}

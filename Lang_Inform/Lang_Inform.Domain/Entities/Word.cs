using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Inform.Domain.Entities
{
    public class Word
    {
        public int WordId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Sound { get; set; }
        public int SoundVol { get; set; }
        public int MeaningId { get; set; }

        public IList<Meaning> Meanings = new List<Meaning>();
    }
}

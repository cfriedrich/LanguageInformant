using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Inform.Domain.Entities
{
    public class Phrase
    {
        byte[] _sound;

        public int PhraseId { get; set; }
        public string Text { get; set; }
        

        public byte[] Sound { get { return _sound; } set { _sound = value; } }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LangInformant.Domain.Entities
{
    public class Word
    {
        public int WordID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Sound { get; set; }
        public int SoundVol { get; set; }
        public virtual Language Language { get; set; }

        public virtual ICollection<Meaning> Meanings { get; set; }
    }
}

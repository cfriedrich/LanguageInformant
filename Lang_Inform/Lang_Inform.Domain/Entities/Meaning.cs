﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang_Inform.Domain.Entities
{
    public class Meaning
    {
        public int MeaningId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public int WordId { get; set; }

        public IList<Word> Words = new List<Word>();
    }
}

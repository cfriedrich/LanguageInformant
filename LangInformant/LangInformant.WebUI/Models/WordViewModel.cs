using LangInformant.Domain.Abstract;
using LangInformant.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LangInformant.WebUI.Models
{
    public class WordViewModel
    {

        private IMeaningRepository meaningRepo;
        private IWordRepository wordRepo;

        public Word word { get; set; }
        public Meaning meaning { get; set; }

    }
}
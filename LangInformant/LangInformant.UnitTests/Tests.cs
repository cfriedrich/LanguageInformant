using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LangInformant.Domain.Entities;

namespace LangInformant.UnitTests
{
    [TestClass]
    public class RepositoryTests
    {
        [TestMethod]
        public void createWordTest()
        {
            Word target = new Word();
            const string NAME = "Testing";
            const string DESCRIPTION = "Test text.";
            const string LANGUAGE = "Spanish";
            const int SOUNDVOL = 4;
            Language testLang = new Language();


            target.Name = NAME;
            target.Description = DESCRIPTION;
            target.SoundVol = SOUNDVOL;
            testLang.Name = LANGUAGE;

            Assert.AreEqual(NAME, target.Name);
            Assert.AreEqual(DESCRIPTION, target.Description);
            Assert.AreEqual(SOUNDVOL, target.SoundVol);
            Assert.AreEqual(LANGUAGE, testLang.Name);
        }
    }
}

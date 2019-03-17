using System;
using NUnit.Framework;

namespace AcronymTests
{
    public class AcronymTests
    {
        [Test]
        public void InputSentenceIsNull()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => Acronym.Acronym.Create(null));
            Assert.That(ex.ParamName, Is.EqualTo("sentence"));
        }

        [Test]
        public void InputSentenceIsEmpty()
        {
            var result = Acronym.Acronym.Create("");
            Assert.That(result, Is.Empty);
        }

        [TestCase("Don't repeat yourself", ExpectedResult = "DRY")]
        [TestCase("Asynchronous Javascript and XML", ExpectedResult = "AJAX")]
        [TestCase("This is my homework.", ExpectedResult = "TIMH")]
        [TestCase("i    am creating    acronyms", ExpectedResult = "IACA")]
        public string InputSentencesWordsAreSeperatedBySpace(string testSentence)
        {
            return Acronym.Acronym.Create(testSentence);
        }

        [TestCase("Complementary metal-oxide semiconductor", ExpectedResult = "CMOS")]
        [TestCase("The cake is sugar-  free", ExpectedResult = "TCISF")]

        [TestCase("Elvis Presley–style dance moves", ExpectedResult = "EPSDM")]
        [TestCase("I opened the door and there she stood—my long lost sister.", ExpectedResult = "IOTDATSSMLLS")]
        public string InputSentencesWordsAreSeperatedByHyphensOrDashes(string testSentence)
        {
            return Acronym.Acronym.Create(testSentence);
        }
    }
}
using System;
using Acronym;
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
    }
}
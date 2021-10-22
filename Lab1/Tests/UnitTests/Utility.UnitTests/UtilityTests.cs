using NUnit.Framework;
using System;
using Utility.Extensions;

namespace Utility.UnitTests
{
    public class UtilityTests
    {
        private string defaultText;
        [SetUp]
        public void Setup()
        {
            defaultText = "  Ana  are    mere    !   Ana e fericita, cu toate ca nu a predat tema la .NET ...";
        }

        [Test]
        public void Given_AString_When_GetNumberOfWordsIsCalled_Then_ReturnsNumberOfWords()
        {
            var expectedNumberOfWords = 15;

            var actualNumberOfWords = defaultText.GetNumberOfWords();

            Assert.AreEqual(expectedNumberOfWords,actualNumberOfWords);
        }

        [Test]
        public void Given_AStringWithNoWords_When_GetNumberOfWordsIsCalled_Then_Returns0()
        {
            var text = ". , ? !    ";
            var expectedNumberOfWords = 0;

            var actualNumberOfWords = text.GetNumberOfWords();

            Assert.AreEqual(expectedNumberOfWords, actualNumberOfWords);
        }

        [Test]
        public void Given_AnEmptyString_When_GetNumberOfWordsIsCalled_Then_Returns0()
        {
            var text = string.Empty;
            var expectedNumberOfWords = 0;

            var actualNumberOfWords = text.GetNumberOfWords();

            Assert.AreEqual(expectedNumberOfWords, actualNumberOfWords);
        }

        [Test]
        public void Given_ANullString_When_GetNumberOfWordsIsCalled_Then_ThrowsException()
        {
            string text = null;

            Assert.Throws<NullReferenceException>(() => text.GetNumberOfWords());
        }
    }
}
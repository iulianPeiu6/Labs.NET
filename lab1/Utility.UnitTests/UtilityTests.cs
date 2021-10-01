using NUnit.Framework;
using Utility.Extensions;

namespace Utility.UnitTests
{
    public class UtilityTests
    {
        private string text;
        [SetUp]
        public void Setup()
        {
            text = "Ana are mere!";
        }

        [Test]
        public void Given_AString_When_GetNumberOfWordsIsCalled_Then_ReturnsNumberOfWords()
        {
            // arrange
            var expectedNumberOfWords = 4;
            // act
            var actualNumberOfWords = text.GetNumberOfWords();
            // assert

            Assert.AreEqual(expectedNumberOfWords,actualNumberOfWords);

        }
    }
}
using NUnit.Framework;
using System;

namespace Models.UnitTests
{
    public class ArchitectTests
    {
        private Architect defaultValidArchitectDataTest;
        private Architect defaultInvalidArchitectDataTest;

        [SetUp]
        public void Setup()
        {
            defaultValidArchitectDataTest = new Architect
            {
                Id = Guid.NewGuid(),
                FirstName = "Roxana",
                LastName = "Timon",
                StartDate = new DateTime(2020, 10, 15),
                EndDate = new DateTime(2021, 10, 15),
                Salary = 1300
            };
            defaultInvalidArchitectDataTest = new Architect
            {
                Id = Guid.NewGuid(),
                LastName = "",
                StartDate = new DateTime(2020, 10, 15),
                Salary = 1300
            };

            Assert.IsNotNull(defaultValidArchitectDataTest);
            Assert.IsNotNull(defaultInvalidArchitectDataTest);
        }

        [Test]
        public void Given_AValidArchitect_When_GetFullNameIsCalled_Then_ReturnExpectedFullName()
        {
            var expectedFullName = "Roxana Timon";

            var actualFullName = defaultValidArchitectDataTest.GetFullName();

            Assert.AreEqual(expectedFullName, actualFullName);
        }

        [Test]
        public void Given_AnInvalidArchitect_When_GetFullNameIsCalled_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(
                () => defaultInvalidArchitectDataTest.GetFullName());
        }

        [Test]
        public void Given_AnActiveArchitect_When_IsActiveIsCalled_Then_ReturnTrue()
        {
            var isActive = defaultValidArchitectDataTest.IsActive();

            Assert.IsTrue(isActive);
        }

        [Test]
        public void Given_AnInactiveArchitect_When_IsActiveIsCalled_Then_ReturnFalse()
        {
            var architect = new Architect
            {
                Id = Guid.NewGuid(),
                FirstName = "Roxana",
                LastName = "Timon",
                StartDate = new DateTime(2012, 10, 15),
                EndDate = new DateTime(2013, 10, 15),
                Salary = 1300
            };

            var isActive = architect.IsActive();

            Assert.IsFalse(isActive);
        }

        [Test]
        public void Given_AValidArchitect_When_SalutationIsCalled_Then_ReturnExpectedResult()
        {
            var expectedSalutation = $"Hello Architect Roxana Timon";

            var actualSalutation = defaultValidArchitectDataTest.Salutation();

            Assert.AreEqual(expectedSalutation, actualSalutation);
        }

        [Test]
        public void Given_AnInvalidArchitect_When_SalutationIsCalled_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(
                () => defaultInvalidArchitectDataTest.Salutation());
        }
    }
}
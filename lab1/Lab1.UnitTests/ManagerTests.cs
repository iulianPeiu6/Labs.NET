using NUnit.Framework;
using System;

namespace Models.UnitTests
{
    public class ManagerTests
    {
        private Manager defaultValidManagerDataTest;
        private Manager defaultInvalidManagerDataTest;

        [SetUp]
        public void Setup()
        {
            defaultValidManagerDataTest = new Manager
            {
                Id = Guid.NewGuid(),
                FirstName = "Roxana",
                LastName = "Timon",
                StartDate = new DateTime(2020, 10, 15),
                EndDate = new DateTime(2021, 10, 15),
                Salary = 1300
            };
            defaultInvalidManagerDataTest = new Manager
            {
                Id = Guid.NewGuid(),
                LastName = "",
                StartDate = new DateTime(2020, 10, 15),
                Salary = 1300
            };

            Assert.IsNotNull(defaultValidManagerDataTest);
        }

        [Test]
        public void Given_AValidManager_When_GetFullNameIsCalled_Then_ReturnExpectedFullName()
        {
            var expectedFullName = "Roxana Timon";

            var actualFullName = defaultValidManagerDataTest.GetFullName();

            Assert.AreEqual(expectedFullName, actualFullName);
        }

        [Test]
        public void Given_AnInvalidArchitect_When_GetFullNameIsCalled_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(
                () => defaultInvalidManagerDataTest.GetFullName());
        }

        [Test]
        public void Given_AnActiveManager_When_IsActiveIsCalled_Then_ReturnTrue()
        {
            var isActive = defaultValidManagerDataTest.IsActive();

            Assert.IsTrue(isActive);
        }

        [Test]
        public void Given_AnInactiveManager_When_IsActiveIsCalled_Then_ReturnFalse()
        {
            var manager = new Manager
            {
                Id = Guid.NewGuid(),
                FirstName = "Roxana",
                LastName = "Timon",
                StartDate = new DateTime(2012, 10, 15),
                EndDate = new DateTime(2013, 10, 15),
                Salary = 1300
            };

            var isActive = manager.IsActive();

            Assert.IsFalse(isActive);
        }

        [Test]
        public void Given_AnValidManager_When_SalutationIsCalled_Then_ReturnExpectedResult()
        {
            var expectedSalutation = $"Hello Manager Roxana Timon";

            var actualSalutation = defaultValidManagerDataTest.Salutation();

            Assert.AreEqual(expectedSalutation, actualSalutation);
        }

        [Test]
        public void Given_AnInvalidManager_When_SalutationIsCalled_Then_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(
                () => defaultInvalidManagerDataTest.Salutation());
        }
    }
}

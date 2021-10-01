using NUnit.Framework;
using System;
using Models;

namespace Models.UnitTests
{
    public class ManagerTests
    {
        private Manager defaultManagerDataTest;

        [SetUp]
        public void Setup()
        {
            defaultManagerDataTest = new Manager
            {
                Id = Guid.NewGuid(),
                FirstName = "Roxana",
                LastName = "Timon",
                StartDate = new DateTime(2020, 10, 15),
                EndDate = new DateTime(2021, 10, 15),
                Salary = 1300
            };

            Assert.IsNotNull(defaultManagerDataTest);
        }

        [Test]
        public void Given_AValidManager_When_GetFullNameIsCalled_Then_ReturnExpectedFullName()
        {
            var expectedFullName = "Roxana Timon";

            var actualFullName = defaultManagerDataTest.GetFullName();

            Assert.AreEqual(expectedFullName, actualFullName);
        }

        [Test]
        public void Given_AnActiveManager_When_IsActiveIsCalled_Then_ReturnTrue()
        {
            var isActive = defaultManagerDataTest.IsActive();

            Assert.IsTrue(isActive);
        }

        [Test]
        public void Given_AnValidManager_When_SalutationIsCalled_Then_ReturnExpectedResult()
        {
            var expectedSalutation = $"Hello Manager Roxana Timon";

            var actualSalutation = defaultManagerDataTest.Salutation();

            Assert.AreEqual(expectedSalutation, actualSalutation);
        }
    }
}

using Models;
using NUnit.Framework;
using System;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestConsole.UnitTests
{
    public class ArchitectTests
    {
        private Architect defaultArchitectDataTest;

        [SetUp]
        public void Setup()
        {
            defaultArchitectDataTest = new Architect
            {
                Id = Guid.NewGuid(),
                FirstName = "Roxana",
                LastName = "Timon",
                StartDate = new DateTime(2020, 10, 15),
                EndDate = new DateTime(2021, 10, 15),
                Salary = 1300
            };

            Assert.IsNotNull(defaultArchitectDataTest);
        }

        [Test]
        public void Given_AValidArchitect_When_GetFullNameIsCalled_Then_ReturnExpectedFullName()
        {
            var expectedFullName = "Roxana Timon";

            var actualFullName = defaultArchitectDataTest.GetFullName();

            Assert.AreEqual(expectedFullName, actualFullName);
        }

        [Test]
        public void Given_AnActiveArchitect_When_IsActiveIsCalled_Then_ReturnTrue()
        {
            var isActive = defaultArchitectDataTest.IsActive();

            Assert.IsTrue(isActive);
        }

        [Test]
        public void Given_AnValidArchitect_When_SalutationIsCalled_Then_ReturnExpectedResult()
        {
            var expectedSalutation = $"Hello Architect Roxana Timon";

            var actualSalutation = defaultArchitectDataTest.Salutation();

            Assert.AreEqual(expectedSalutation, actualSalutation);
        }
    }
}
using ArmyLibrary;
using System;

namespace ArmyLibrary.UnitTests
{
    [TestFixture]
    public class ServicemanTests
    {
        static Serviceman serviceman;

        [SetUp]
        public void Setup()
        {
            serviceman = new Serviceman("John", "Smith", 122, "major", 12, "12.02.1999", TypeOfService.Contract);
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(serviceman.Name, Is.EqualTo("John"));
            Assert.That(serviceman.Surname, Is.EqualTo("Smith"));
            Assert.That(serviceman.NumMillitaryTicket, Is.EqualTo(122));
            Assert.That(serviceman.Rank, Is.EqualTo("major"));
            Assert.That(serviceman.NumMillitaryUnit, Is.EqualTo(12));
            Assert.That(serviceman.Date, Is.EqualTo(new DateTime(1999,4,12)));
            Assert.That(serviceman.TypeOfService, Is.EqualTo(TypeOfService.Contract));
        }
        [Test]
        public void GetInfo_Person_ValuesString()
        {
            string expectedInfo = ("John Smith");
            expectedInfo += ("Номер военного билета:12");
        }
    }
}
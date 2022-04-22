using NUnit.Framework;
using teller_models;

using System;
using System.IO;

namespace teller_models.Tests
{
    [TestFixture]
    public class TellerTests
    {
        [Test]
        public void TellerTest()
        {
            var teller = new Teller();
            Assert.AreEqual(0, teller.Waarde);
        }

        [Test]
        public void VerhoogTest()
        {
            var teller = new Teller();
            teller.Verhoog();
            Assert.AreEqual(1, teller.Waarde);
        }

        [Test]
        public void VerlaagTest()
        {
            var teller = new Teller();
            teller.Verlaag();
            Assert.AreEqual(-1, teller.Waarde);
        }

        [Test]
        public void ResettenTest()
        {
            var teller = new Teller();
            teller.Verhoog();
            teller.Verhoog();
            teller.Verhoog();
            teller.Resetten();
            Assert.AreEqual(0, teller.Waarde);
        }

        [Test]
        public void ToonGegevensTest()
        {
            var teller = new Teller();
            StringAssert.Contains("Waarde van teller is 0", teller.ToonGegevens());
        }
    }
}
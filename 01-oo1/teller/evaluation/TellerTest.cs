using Xunit;
using teller_models;
using System;
using System.Collections.Generic;
using System.Text;

namespace teller_models.Tests
{
    public class TellerTests
    {
        [Fact()]
        public void TellerTest()
        {
            var teller = new Teller();
            Assert.Equal(0, teller.Waarde);
        }

        [Fact()]
        public void VerhoogTest()
        {
            var teller = new Teller();
            teller.Verhoog();
            Assert.Equal(1, teller.Waarde);
        }

        [Fact()]
        public void VerlaagTest()
        {
            var teller = new Teller();
            teller.Verlaag();
            Assert.Equal(-1, teller.Waarde);
        }

        [Fact()]
        public void ResettenTest()
        {
            var teller = new Teller();
            teller.Verhoog();
            teller.Verhoog();
            teller.Verhoog();
            teller.Resetten();
            Assert.Equal(0, teller.Waarde);
        }

        [Fact()]
        public void ToonGegevensTest()
        {
            var teller = new Teller();
            Assert.Contains("Waarde van teller is 0", teller.ToonGegevens());
        }
    }
}
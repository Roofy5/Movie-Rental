using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WypozyczalniaDLL;

namespace Tests
{
    [TestClass]
    public class PersonalDataTests
    {
        [TestMethod]
        public void PersonalData_Constructor()
        {
            PersonalData data = new PersonalData("Klaudia", "Kaczka", new DateTime(1995, 4, 28));

            Assert.AreEqual("Klaudia", data.Name);
            Assert.AreEqual("Kaczka", data.Surname);
            Assert.AreEqual(1995, data.BirthDate.Year);
            Assert.AreEqual(4, data.BirthDate.Month);
            Assert.AreEqual(28, data.BirthDate.Day);
        }

        [TestMethod]
        public void PersonalData_ToString()
        {
            PersonalData data = new PersonalData("Klaudia", "Kaczka", new DateTime(1995, 4, 28));

            bool takieSame = false;
            if (string.Compare(data.ToString(), "Imie: Klaudia, Nazwisko: Kaczka, Data Urodzenia: " + new DateTime(1995, 4, 28).ToShortDateString(), System.Globalization.CultureInfo.InvariantCulture, System.Globalization.CompareOptions.None) == 0)
                takieSame = true;

            Assert.AreEqual(true, takieSame);
        }
    }
}

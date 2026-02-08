using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Projet_TransConnect_RUFFENACH_SAADI
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Salarie chauffeur1 = new Salarie(14, "Romu", "Mr", new DateTime(1982, 2, 18), "Adresse", "email@exemple.com", "0123456789", new DateTime(2023, 4, 22), "Chauffeur", 80);
            Salarie result = Entreprise.Find("Chauffeur");
            Assert.AreEqual(chauffeur1, result);
        }
    }
}

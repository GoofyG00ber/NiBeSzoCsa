using Microsoft.VisualStudio.TestTools.UnitTesting;
using kliens_alkalmazas;
using Hotcakes.CommerceDTO.v1.Client;
using System;
using System.Collections.Generic;
using System.Linq;

namespace kliens_app.Tests
{
    [TestClass]
    public class UserControlKeszletTests
    {
        [TestMethod]
        public void Raktar_API_hivas_test()
        {
            // Act
            var api = typeof(UserControlKeszlet)
                      .GetMethod("apiHivas", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                      .Invoke(null, null) as Api;

            // Assert
            Assert.IsNotNull(api);
        }

        [TestMethod]
        public void Termek_OptimálisMennyiség_Számítás_Test()
        {
            // Arrange
            var termek = new Termek
            {
                MinimálisMennyiség = 5,
                Raktáron = 2,
                BeszerzésiÁr = 1000
            };

            // Act & Assert
            Assert.AreEqual(10, termek.OptimálisMennyiség);
            Assert.AreEqual(8, termek.OptimálishozSzükségesDb);
            Assert.AreEqual(8000, termek.OptimálishozSzükségesFt);
        }

        [TestMethod]
        public void Termek_OptimálisMennyiség_Különböző_Értékek_Test()
        {
            // Arrange
            var termek1 = new Termek { MinimálisMennyiség = 1 };
            var termek2 = new Termek { MinimálisMennyiség = 15 };
            var termek3 = new Termek { MinimálisMennyiség = 50 };

            // Act & Assert
            Assert.AreEqual(3, termek1.OptimálisMennyiség);
            Assert.AreEqual(30, termek2.OptimálisMennyiség);
            Assert.AreEqual(100, termek3.OptimálisMennyiség);
        }

        [TestMethod]
        public void Termek_Készlet_Frissítés_Test()
        {
            // Arrange
            var termek = new Termek
            {
                MinimálisMennyiség = 5,  // This will set OptimálisMennyiség to 10
                Raktáron = 5,
                BeszerzésiÁr = 1000
            };

            // Act
            termek.Raktáron = 8;  // This will trigger recalculation

            // Assert
            Assert.AreEqual(8, termek.Raktáron);
            Assert.AreEqual(2, termek.OptimálishozSzükségesDb);
            Assert.AreEqual(2000, termek.OptimálishozSzükségesFt);
        }

        [TestMethod]
        public void Termek_Beszállító_Szűrés_Test()
        {
            // Arrange
            var termekek = new List<Termek>
            {
                new Termek { Név = "Termék1", Beszállító = "Beszállító1" },
                new Termek { Név = "Termék2", Beszállító = "Beszállító2" },
                new Termek { Név = "Termék3", Beszállító = "Beszállító1" }
            };

            // Act
            var szurtTermekek = termekek.Where(t => t.Beszállító == "Beszállító1").ToList();

            // Assert
            Assert.AreEqual(2, szurtTermekek.Count);
            Assert.IsTrue(szurtTermekek.All(t => t.Beszállító == "Beszállító1"));
        }
    }

    [TestClass]
    public class UserControlRendelesTests
    {
        [TestMethod]
        public void Rendeles_API_hivas_test()
        {
            // Act
            var api = typeof(UserControlRendeles)
                      .GetMethod("apiHivas", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                      .Invoke(null, null) as Api;

            // Assert
            Assert.IsNotNull(api);
        }

        [TestMethod]
        public void Rendeles_Státusz_Frissítés_Test()
        {
            // Arrange
            var rendeles = new Rendeles
            {
                Státusz = "Received",
                Bvin = "test-bvin"
            };

            // Act & Assert
            Assert.IsTrue(rendeles.Státusz == "Received");
            rendeles.Státusz = "Ready for Shipping";
            Assert.AreEqual("Ready for Shipping", rendeles.Státusz);
        }

        [TestMethod]
        public void Rendeles_Ár_Kerekítés_Test()
        {
            // Arrange
            var rendeles = new Rendeles
            {
                Ár = 1000.567m
            };

            // Act & Assert
            Assert.AreEqual(1000.57m, Math.Round(rendeles.Ár, 2));
        }

        [TestMethod]
        public void Rendeles_Dátum_Kezelés_Test()
        {
            // Arrange
            var datum = DateTime.UtcNow;
            var rendeles = new Rendeles
            {
                Dátum = datum
            };

            // Act & Assert
            Assert.AreEqual(datum, rendeles.Dátum);
            Assert.IsTrue(rendeles.Dátum.Kind == DateTimeKind.Utc);
        }

        [TestMethod]
        public void Rendeles_Email_Validáció_Test()
        {
            // Arrange
            var rendeles = new Rendeles
            {
                Email = "test@example.com"
            };

            // Act & Assert
            Assert.IsTrue(rendeles.Email.Contains("@"));
            Assert.IsTrue(rendeles.Email.Contains("."));
        }
    }
}

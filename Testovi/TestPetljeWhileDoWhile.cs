using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp.KontrolaToka;

namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestPetljeWhileDoWhile : ConsoleTest
    {
        [TestMethod]
        public void PetljeWhileDoWhile_BrojBacanjaDoBačeneŠestice()
        {
            PetljeWhileDoWhile.BrojBacanjaDoBačeneŠestice();
            Assert.IsFalse(cw.IsEmpty); // barem jedno bacanje!

            int n = 1;
            while (!cw.IsEmpty)
            {
                string unos = cw.GetString();
                string početak = $"{n}. pokušaj: ";
                Assert.IsTrue(unos.StartsWith(početak));
                string broj = unos.Substring(početak.Length);
                int i = int.Parse(broj);
                Assert.IsTrue(i >= 1 && (i < 6 || (i == 6 && cw.IsEmpty)));
                ++n;
            }
        }

        [TestMethod]
        public void PetljeWhileDoWhile_BacajDokNeProđe12Polja()
        {
            int početno = 5;
            int ukupno = PetljeWhileDoWhile.BacajDokNeProđe12Polja(početno);
            Assert.IsTrue(ukupno >= 12 && ukupno < 18);
            Assert.IsFalse(cw.IsEmpty);

            while (!cw.IsEmpty)
            {
                string unos = cw.GetString();
                Assert.IsTrue(unos.StartsWith("Bacanje: "));
                string broj = unos.Substring("Bacanje: ".Length);
                int i = int.Parse(broj);
                Assert.IsTrue(i >= 1 && i <= 6);
                unos = cw.GetString();
                Assert.IsTrue(unos.StartsWith("Ukupno: "));
                broj = unos.Substring("Ukupno: ".Length);
                i = int.Parse(broj);
                Assert.IsTrue(i >= početno && (i < 12 || cw.IsEmpty));
            }
        }

        [TestMethod]
        public void PetljeWhileDoWhile_BacajDokNeProđe12PoljaJePrazanZa12iliViše()
        {
            Assert.AreEqual(12, PetljeWhileDoWhile.BacajDokNeProđe12Polja(12));
            Assert.IsTrue(cw.IsEmpty); // ne smije biti niti jedno bacanje!

            Assert.AreEqual(16, PetljeWhileDoWhile.BacajDokNeProđe12Polja(16));
            Assert.IsTrue(cw.IsEmpty); // ne smije biti niti jedno bacanje!
        }
    }
}

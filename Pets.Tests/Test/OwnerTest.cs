using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Pets.Domain.ValueObjects;
using Pets.Domain.Enums;
using Pets.Domain.Entities.PetContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pets.Tests.Test
{
    [TestClass]
    public class OwnerTest
    {

        // red green refactory
        [TestMethod]
        public void Insert_Invalid_Name()
        {
            var owner = new Owner(
                // Nomes errados
                name: new Name("1", "1"),
                email: "corporacoesww@meta.br",
                document: new Document("15489521090", EDocumentType.CPF));
            Assert.AreEqual(false, owner.Validation());
        }
        [TestMethod]
        public void Insert_Invalid_Mail()
        {
            var owner = new Owner(
                name: new Name("Walter b", "White b"),
                // Email errado
                email: "corporacoeswwmeta.br",
                document: new Document("15489521090", EDocumentType.CPF));
            Assert.AreEqual(false, owner.Validation());
        }
        [TestMethod]
        public void Insert_Invalid_Document()
        {
            var owner = new Owner(
                name: new Name("Walter b", "White b"),
                email: "corporacoesww@meta.br",
                // Document errado
                document: new Document("15489521099", EDocumentType.CPF));
            Assert.AreEqual(false, owner.Validation());
        }
    }
}
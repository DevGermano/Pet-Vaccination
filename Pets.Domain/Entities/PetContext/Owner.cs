using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Validations;
using Pets.Domain.Validations.Interfaces;
using Pets.Domain.ValueObjects;

namespace Pets.Domain.Entities.PetContext
{
    public class Owner : BaseEntity, IContract
    {


        public Owner(Name name, string email, Document document)
        : base(name)
        {
            Email = email;
            Document = document;

        }

        public string Email { get; private set; }
        public Document Document { get; private set; }
        public void SetEmail(string email)
        {
            Email = email;
        }

        public override bool Validation()
        {
            var contracts =
            new ContractValidations<Owner>()
            .FirstNameIsOk(this.Name, 20, 5, "O primeiro nome deve conter mais de 5 e menos de 20 caracteres", "FirstName")
            .LastNameIsOk(this.Name, 20, 5, "O segundo nome deve conter mais de 5 e menos de 20 caracteres", "LastName")
            .EmailIsOk(this.Email, "Digite seu email com a forma user@user.com", "Email")
            .DocumentIsValid(this.Document, "O documento não é válido", "Documento");
            return contracts.isValid();
        }
    }
}
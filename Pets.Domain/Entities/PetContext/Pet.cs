using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Validations;
using Pets.Domain.Validations.Interfaces;
using Pets.Domain.ValueObjects;

namespace Pets.Domain.Entities.PetContext
{
    public class Pet : BaseEntity, IContract
    {
        public Pet(Name name, int identifier) : base(name)
        {
            Identifier = identifier;
        }

        public int Identifier { get; private set; }

        public void SetIdentifier(int identifier)
        {
            Identifier = identifier;
        }

        public override bool Validation()
        {
            var contracts =
                       new ContractValidations<Pet>()
                       .FirstNameIsOk(this.Name, 20, 5, "O primeiro nome deve conter mais de 5 e menos de 20 caracteres", "FirstName")
                       .LastNameIsOk(this.Name, 20, 5, "O segundo nome deve conter mais de 5 e menos de 20 caracteres", "LastName");
            return contracts.isValid();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Validations;
using Pets.Domain.Validations.Interfaces;

namespace Pets.Domain.Entities.VaccineContext
{
    public class Category : BaseEntity, IContract
    {
        public Category(string description) : base(description)
        {
        }
        public override void setDescription(string description)
        {
            base.setDescription(description);
        }

        public override bool Validation()
        {
            var contracts =
            new ContractValidations<Category>()
            .DescriptionIsOk(this.Description, 5, 20, "A descrição deve ter entre 5 e 20 caracteres", "Description");
            return contracts.isValid();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Validations;
using Pets.Domain.Validations.Interfaces;

namespace Pets.Domain.Entities.VaccineContext
{
    public class Vaccine : BaseEntity, IContract
    {
        public Vaccine(string description, Guid categoryId, Guid petId) : base(description)
        {
            CategoryId = categoryId;
            PetId = petId;
        }

        public Guid CategoryId { get; private set; }
        public Guid PetId { get; private set; }

        public override void setDescription(string description)
        {
            base.setDescription(description);
        }

        public override bool Validation()
        {
            var contracts =
            new ContractValidations<Category>()
            .DescriptionIsOk(this.Description, 5, 20, "A descrição deve ter entre 5 e 20 caracteres", "Description")
            .GuidIsOk(this.CategoryId, 10, 40, "A sua categoria não está certa", "CategoryId")
            .GuidIsOk(this.PetId, 10, 40, "O nome do pet está correto", "PetId");
            return contracts.isValid();
        }
    }
}
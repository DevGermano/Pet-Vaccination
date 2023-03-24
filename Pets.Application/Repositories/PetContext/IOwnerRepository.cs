using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Application.Output.Requests.PetsRequests;
using Pets.Application.Output.Results.Interfaces;
using Pets.Domain.Entities.PetContext;

namespace Pets.Application.Repositories.PetContext
{
    public interface IOwnerRepository
    {
        void InsertOwner(Owner owner);
        Task<OwnerRequest> GetOwnerByDocumentAsync(string document);

        Task<OwnerRequest> GetOwnerByEmailAsync(string email);

        IResultBase DeleteOwnerById(Guid ownerId);
    }

}
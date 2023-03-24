using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Entities.VaccineContext;

namespace Pets.Application.Repositories.VaccineContext
{
    public interface IVaccineRepository
    {
        void InsertVaccine(Vaccine vaccine);
    }
}
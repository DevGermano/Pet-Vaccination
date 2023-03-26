using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Application.Input.Commands.Interfaces;

namespace Pets.Application.Input.Commands.VaccineContext
{
    public class InsertVaccineCommand : ICommandBase
    {

        public Guid CategoryId { get; set; }
        public Guid PetId { get; set; }
        public string Description { get; set; }
    }
}
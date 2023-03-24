using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pets.Application.Output.DTO
{
    public struct VaccineDTO
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }
    }
}
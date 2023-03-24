using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pets.Application.Output.DTO
{
    public struct CategoryDTO
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

    }
}
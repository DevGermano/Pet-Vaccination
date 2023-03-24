using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Application.Output.DTO;
using Pets.Application.Output.Results;

namespace Pets.Application.Output.Requests.VaccineRequest
{
    public class CategoryRequest
    {
        public Result Result { get; set; }
        public IEnumerable<CategoryDTO> Categories { get; set; }
    }
}
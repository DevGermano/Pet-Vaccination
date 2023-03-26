using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Application.Input.Commands.Interfaces;

namespace Pets.Application.Input.Commands.VaccineContext
{
    public class InsertCategoryCommand : ICommandBase
    {

        public string Description { get; set; }
    }
}
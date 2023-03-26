using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Application.Input.Commands.Interfaces;
using Pets.Application.Output.Results.Interfaces;

namespace Pets.Application.Input.Handlers.Interfaces
{
    public interface IHandlerBase<in T> where T : ICommandBase
    {
        IResultBase Handle(T command);
    }
}
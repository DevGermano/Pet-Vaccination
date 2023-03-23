using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Notifications;

namespace Pets.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> GuidIsOk(
            object guid,
            short minLength,
            short maxLength,
            string message,
            string propertyName
    )
        {
            if (guid is Guid)
            {
                AddNotification(new Notification(message, propertyName));
            }
            return this;
        }
    }
}
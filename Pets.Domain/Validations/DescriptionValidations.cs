using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Notifications;

namespace Pets.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> DescriptionIsOk(string description, short minLength, short maxLength, string message, string propertyName)
        {
            if (string.IsNullOrEmpty(description) || (description.Length < minLength))
            {
                AddNotification(new Notification(message, propertyName));
            }
            return this;
        }
    }
}
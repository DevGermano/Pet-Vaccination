using Pets.Domain.Notifications;
using Pets.Domain.ValueObjects;

namespace Pets.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> FirstNameIsOk(
            Name name,
            short maxLength,
            short minLength,
            string message,
            string propertyName
        )
        {
            if (string.IsNullOrEmpty(name.FirstName) || name.FirstName.Length < minLength || name.FirstName.Length > maxLength)
            {
                AddNotification(new Notification(message, propertyName));
            }
            return this;
        }

        public ContractValidations<T> LastNameIsOk(Name name, short maxLength, short minLength, string message, string propertyName)
        {
            if (string.IsNullOrEmpty(name.FirstName) || name.FirstName.Length < minLength || name.FirstName.Length > maxLength)
            {
                AddNotification(new Notification(message, propertyName));
            }
            return this;
        }

    }
}
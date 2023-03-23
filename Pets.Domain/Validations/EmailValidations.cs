using System.Text.RegularExpressions;
using Pets.Domain.Notifications;

namespace Pets.Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> EmailIsOk(string email, string message, string propertyName)
        {
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                AddNotification(new Notification(message, propertyName));
            }
            return this;
        }

    }
}
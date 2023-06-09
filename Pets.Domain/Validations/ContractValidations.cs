using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Notifications;
using Pets.Domain.Validations.Interfaces;

namespace Pets.Domain.Validations
{
    public partial class ContractValidations<T> where T : IContract
    {

        private List<Notification> _notifications;

        public ContractValidations()
        {
            _notifications = new List<Notification>();
        }

        public IReadOnlyCollection<Notification> Notifications => _notifications;

        public void AddNotification(Notification notification)
        {
            _notifications.Add(notification);
        }

        public bool isValid()
        {
            return _notifications.Count == 0 ? true : false;
        }
    }
}
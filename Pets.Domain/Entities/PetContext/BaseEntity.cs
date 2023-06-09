using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Notifications;
using Pets.Domain.Validations.Interfaces;
using Pets.Domain.ValueObjects;

namespace Pets.Domain.Entities.PetContext
{
    public abstract class BaseEntity : IValidations
    {

        private List<Notification> _notifications;
        public BaseEntity(Name name)
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.UtcNow;
            Name = name;
        }
        public Guid Id { get; private set; }
        public Name Name { get; private set; }
        public DateTime CreateDate { get; private set; }

        public IReadOnlyCollection<Notification> Notifications => _notifications;

        protected void setNotificationsList(List<Notification> notifications)
        {
            _notifications = notifications;
        }

        public abstract bool Validation();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Domain.Notifications;
using Pets.Domain.Validations.Interfaces;

namespace Pets.Domain.Entities.VaccineContext
{
    public abstract class BaseEntity : IValidations
    {
        private List<Notification> _notifications;
        protected BaseEntity(string description)
        {
            Id = Guid.NewGuid();
            CreateDate = DateTime.UtcNow;
            Description = description;
        }

        public Guid Id { get; private set; }
        public DateTime CreateDate { get; private set; }
        public string Description { get; private set; }

        public virtual void setDescription(string description)
        {
            Description = description;
        }

        public IReadOnlyCollection<Notification> Notifications => _notifications;
        public abstract bool Validation();
    }
}
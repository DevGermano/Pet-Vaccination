using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Application.Output.Results.Interfaces;
using Pets.Domain.Notifications;

namespace Pets.Application.Output.Results
{
    public class Result : IResultBase
    {
        private List<Notification> _notifications;

        public Result(int resultCode, string message, bool isOk)
        {
            ResultCode = resultCode;
            Message = message;
            this.isOk = isOk;
            _notifications = new List<Notification>();
        }
        public int ResultCode { get; private set; }
        public string Message { get; private set; }
        public bool isOk { get; private set; }
        public object Data { get; private set; }
        public IReadOnlyCollection<Notification> Notifications => _notifications;
        public void setNotifications(List<Notification> notifications)
        {
            _notifications = notifications;
        }
        public void SetData(object data)
        {
            Data = data;
        }
    }
}